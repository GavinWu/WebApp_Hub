$PathToAppCmdExe = "C:\Windows\System32\inetsrv"
$AppCmdExeName = ".\appcmd.exe"
$AppPoolName = "GavinAppPool"
$SiteName = "GavinSite"
$IdentityType = "LocalService"
$RuntimeVersion = "v4.0"
$HttpPort = "http://*:51130"
$SiteId = 50
$PhysicalPathToWebSite = "C:\source\WebApp_Hub\WebApp"

#Add app pool
& $PathToAppCmdExe$AppCmdExeName add appPool /name:$AppPoolName

#change app Pool identityType
& $PathToAppCmdExe$AppCmdExeName set appPool $AppPoolName /processModel.IdentityType:$identityType
& $PathToAppCmdExe$AppCmdExeName set appPool $AppPoolName /managedRuntimeVersion:$RuntimeVersion

#add site
& $PathToAppCmdExe$AppCmdExeName add site /name:$SiteName /id:$SiteId /bindings:$HttpPort /physicalpath:$PhysicalPathToWebSite

#change sites app pool assignment
& $PathToAppCmdExe$AppCmdExeName set site $SiteName /applicationDefaults.applicationPool:$AppPoolName

#start site
& $PathToAppCmdExe$AppCmdExeName start site /site.name:$SiteName




