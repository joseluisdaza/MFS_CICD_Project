using NUnit.Framework;

namespace AdminSolution.Test
{
  public class Tests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test0()
    {
      Assert.Pass();
    }

    [Test] public void Test1() => Assert.Pass();
    [Test] public void Test2() => Assert.AreEqual(2, 1 + 1);
    [Test] public void Test3() => Assert.IsTrue(true);
    [Test] public void Test4() => Assert.IsFalse(false);
    [Test] public void Test5() => Assert.That("hello", Is.EqualTo("hello"));
    [Test] public void Test6() => Assert.That(5, Is.GreaterThan(1));
    [Test] public void Test7() => Assert.That(3.14, Is.AtLeast(3));
    [Test] public void Test8() => Assert.That(new int[] { 1, 2, 3 }, Has.Length.EqualTo(3));
    [Test] public void Test9() => Assert.That(() => 1 / 1, Throws.Nothing);
    [Test] public void Test10() => Assert.That("abc".Contains("a"));
    }
}