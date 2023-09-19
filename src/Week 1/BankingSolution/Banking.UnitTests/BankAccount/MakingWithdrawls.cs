using Banking.Domain;

namespace Banking.UnitTests.BankAccount;
public class MakingWithdrawls
{
    [Theory]
    [InlineData(82.23)]
    [InlineData(200)]
    public void MakingAWithdrawalDecreasesTheBalance(decimal amountToWithdraw)
    {
        // Given
        var account = new Account();
        var openingBalance = account.GetBalance();



        // When
        account.Withdraw(amountToWithdraw);



        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
    }

    [Fact]
    public void CantakeEntireBalance()
    {
        var account = new Account();

        account.Withdraw(account.GetBalance());

        Assert.Equal(0, account.GetBalance());
    }


}
