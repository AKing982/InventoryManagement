using InventoryManagement.Model;
using NUnit.Framework;

namespace InventoryManagement.Tests.Model;

[TestFixture]
[TestOf(typeof(TrackingNumber))]
public class TrackingNumberTest
{
    private TrackingNumber _testSubject;
    
    [SetUp]
    public void SetUp()
    {
        _testSubject = new TrackingNumber("", "", "");
    }

    [Test]
    public void METHOD()
    {
        
    }
}