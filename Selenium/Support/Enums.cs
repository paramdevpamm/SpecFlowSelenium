using System.ComponentModel;

public enum PageName
{
    Home,
    SignIn,
    CreateAccount,
    MyAccount,
    swagLab
}

public enum Element
{
    SignInLink,
    SignInButton,
    NewUserEmail,
    ExistingUserEmail,
    CreateAnAccountButton,
    MrRadioButtonOption,
    MrsRadioButtonOption,
    CustomerFirstName,
    CustomerLastName,
    Email,
    Password,
    BirthdateMonth,
    BirthdateDay,
    BirthdateYear,
    AddressFirstName,
    AddressLastName,
    Address,
    City,
    State,
    Zip,
    Country,
    MobilePhone,
    AddressAlias,
    RegisterButton,
    SignOutLink,
    swagLabUserName,
    swagLabPassword,
    swagLabLoginButton,
    swaglabLoginErrorText,
    swagLabLoginHeader,
    swagLabInventoryItemName,
    swagLabShoppingCartContainer,
    swagLabAddToCartBackPack,
    swagLabAddToCartBikeLight,
    swagLabAddToCartBoltTShirt,
    swagLabAddToCartFleeceJacket,
    swagLabAddToCartOnesie,
    swagLabAddTShirtRed,
}

public enum Title
{
    Mr,
    Mrs
}

public enum Month
{
    January,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}

public enum State
{
    Washington
}

public enum Country
{
    [Description("United States")]
    UnitedStates
}