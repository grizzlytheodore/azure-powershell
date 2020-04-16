# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.SYNOPSIS
Test Create and resize Azure HDInsight Cluster
#>

function Test-ClusterRelatedCommands{

	# Create some resources that will be used throughout test
	try
	{
		# test create cluster
		$vaultName="vault-ps-test"
		$vaultName=Generate-Name($vaultName)
		$cluster = Create-Cluster -vaultName $vaultName
		Assert-NotNull $cluster
		
		#test Get-AzHDInsightCluster
		$resultCluster = Get-AzHDInsightCluster -ClusterName $cluster.Name
		Assert-AreEqual $resultCluster.Name  $cluster.Name
		
		#test Set-AzHDInsightClusterSize
		$resizeCluster = Set-AzHDInsightClusterSize -ClusterName $cluster.Name -ResourceGroupName $cluster.ResourceGroup `
		-TargetInstanceCount 3
		Assert-AreEqual $resizeCluster.CoresUsed 20

		#test Set-AzHDInsightClusterDiskEncryptionKey
		$keyName="newkey-ps-test"
		$keyName=Generate-Name($keyName)
		$encryptionKeyVault=Get-AzKeyVault -VaultName $vaultName
		$encryptionKey=Add-AzKeyVaultKey -VaultName $vaultName -Name $keyName -Destination 'Software'

		$rotateKeyCluster = Set-AzHDInsightClusterDiskEncryptionKey -ClusterName $cluster.Name -ResourceGroupName $cluster.ResourceGroup `
		-EncryptionKeyName $encryptionKey.Name -EncryptionKeyVersion $encryptionKey.Version -EncryptionVaultUri $encryptionKeyVault.VaultUri
		
		Assert-AreEqual $rotateKeyCluster.Properties.DiskEncryptionProperties.KeyVersion $encryptionKey.Version
		Assert-AreEqual $rotateKeyCluster.Properties.DiskEncryptionProperties.KeyName $encryptionKey.KeyName
	}
	finally
	{
		# Delete cluster and resource group
		Remove-AzHDInsightCluster -ClusterName $cluster.Name
		Remove-AzResourceGroup -ResourceGroupName $cluster.ResourceGroup
	}

}
