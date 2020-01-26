*** Settings ***
Documentation
Library           SeleniumLibrary

*** Variables ***
${SERVER}       automationpractice.com
${BROWSER}      Chrome
${DELAY}        0
${VALID EMAIL REGISTER}   jurek11111@wp111.pl
${VALID EMAIL}   jurek11111@wp111.pl
${INVALID EMAIL}     invalid@gmail.com
${VALID PASSWORD REGISTER}   Valid_password123
${VALID PASSWORD}   Valid_password123
${INVALID PASSWORD}     Invalid_password123
${MAIN URL}    http://${SERVER}/index.php
${SIGNIN URL}    http://${SERVER}/index.php?controller=authentication&back=my-account
${T-SHIRTS URL}  http://${SERVER}/index.php?id_category=3&controller=category
${ALERT URL}    http://${SERVER}/index.php?controller=authentication

*** Keywords ***
Open Browser To Main Page
    Open Browser    ${MAIN URL}    ${BROWSER}
    Title Should Be    My Store
Go To T-shirts Page
    Click Element      css = .sf-menu > li:nth-child(1) > a:nth-child(1)
T-shirts Page Should Be Open
    Location Should Be  ${T-SHIRTS URL}
Input Email
    [Arguments]    ${email}
    Input Text    email    ${email}
Input Password
    [Arguments]    ${passwd}
    Input Text    passwd    ${passwd}
Log In
    Click Element   class=login
Submit Credentials
    Click Button    SubmitLogin
My Account Page Should Be Open
    Title Should Be    My account - My Store
Input Create Email
    [Arguments]    ${email}
    Input Text    email_create    ${email}
Create Account
    Click Button    xpath=//*[@id="SubmitCreate"]
Submit Account
    Click Button    xpath=//*[@id="submitAccount"]
Alert Page Should Be Open
    Location Should Be   ${ALERT URL}
Register Page Should Be Open
    Title Should Be    Login - My Store
Choose Male Title
    Select Radio Button    id_gender  1
Input FirstName
    Input Text    xpath=//*[@id="customer_firstname"]  Lady
Input LastName
    Input Text    xpath=//*[@id="customer_lastname"]  Gaga
Input RegisterPassword
    Input Text    xpath=//*[@id="passwd"]  Valid_password123
Select Day
    Select From List by Value    xpath=//*[@id="days"]  15
Select Months
    Select From List by Value    xpath=//*[@id="months"]  1
Select Yours
    Select From List by Value    xpath=//*[@id="years"]  2000
Input Address
    Input Text    xpath=//*[@id="address1"]  Cedrowa
Input City
    Input Text    xpath=//*[@id="city"]  gda
Select State
    Select From List by Value    xpath=//*[@id="id_state"]  2
Input PostCode
    Input Text    xpath=//*[@id="postcode"]  55555
Input Phone
    Input Text    xpath=//*[@id="phone_mobile"]  +123445