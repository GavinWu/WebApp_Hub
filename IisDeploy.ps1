navigate to inetsrv C windows system 32 inetsrv
use appcmd.exe 

//Add app pool
add appPool /name:"TestPool"

//change app Pool identityType
set appPool "TestPool" /processModel.IdentityType:Localservice

//add site
add site /name:"name" /id:y /bindings:http/*:51130: /physicalpath:"C:/...."

//change sites app pool assignment
set site "Test" /applicationDefaults.applicationPool:TestPool




