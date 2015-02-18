$FolderToChangeACL = "WebApp"
$PermissionGroupName = "Local Service"

$Acl = Get-Acl "$PSScriptRoot\$FolderToChangeACL"

$inherit = [system.security.accesscontrol.InheritanceFlags]"ContainerInherit, ObjectInherit"
$propagation = [system.security.accesscontrol.PropagationFlags]"NoPropagateInherit"
$Ar = New-Object System.Security.AccessControl.FileSystemAccessRule( $PermissionGroupName,"FullControl", $inherit, $propagation, "Allow")

$Acl.SetAccessRule($Ar)
Set-Acl "$PSScriptRoot\$FolderToChangeACL" $Acl