*** Settings ***
Library  OperatingSystem

*** Variables ***
${run}


*** Test Cases ***
Valid Run
    run application


*** Keywords ***

run application
    run application ${LOGIN URL}   ${BROWSER}

