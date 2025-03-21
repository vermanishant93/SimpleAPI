using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{
    ValuesController controller = new ValuesController();
    [Fact]
    public void GetReturnsMyName()
    {
        int id = 1;
        var returnValue = controller.Get(id);
        Assert.Equal($"Reponse, Id: {id}", returnValue.Value);
    }

    [Fact]
    public void Test1()
    {

    }
}
