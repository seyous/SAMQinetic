﻿clear
set report_txt=Textreport_%date:~-4,4%_%date:~-7,2%_%date:~-10,2%_%time:~1,1%%time:~3,2%%time:~6,2%.txt
echo report_txt

set report_xml=xmlreport_%date:~-4,4%_%date:~-7,2%_%date:~-10,2%_%time:~1,1%%time:~3,2%%time:~6,2%.xml
echo report_xml

set report_html=htmlreport_%date:~-4,4%_%date:~-7,2%_%date:~-10,2%_%time:~1,1%%time:~3,2%%time:~6,2%.html
echo report_html


..\packages\NUnit.ConsoleRunner.3.10.0\tools\nunit3-console.exe --labels=All  --where "cat == insert || cat = navigation" --out=..\TestResults\ReportFiles\%report_txt% "--result=..\TestResults\ReportFiles\%report_xml%;format=nunit2" ..\bin\Debug\SAM.dll


..\packages\SpecFlow.2.4.1\tools\specflow.exe nunitexecutionreport --ProjectFile ..\SAM.csproj --xmlTestResult ..\TestResults\ReportFiles\%report_xml% --testOutput ..\TestResults\ReportFiles\%report_txt% --OutputFile ..\TestResults\ReportFiles\%report_html%



rem Run smoke tests only with  "cat == smoke && cat != wip && cat != manual && cat != regression"






