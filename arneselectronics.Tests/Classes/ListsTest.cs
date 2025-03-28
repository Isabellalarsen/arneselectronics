using arneselectronics;
using Avalonia.Controls;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using Avalonia.Collections;
using Dapper;
using Npgsql;
using NUnit.Framework;

namespace arneselectronics.Tests.Classes;

[TestFixture]
[TestOf(typeof(ListInitializer))]
public class ListsTest
{
    ListInitializer listInitializer;
    
    [SetUp]
    public void Setup()
    {
        listInitializer = ListInitializer.Instance;
        //Clears to make sure they are empty from beginning
        listInitializer.CartList.Clear();
        listInitializer.AccessoriesList.Clear();
        listInitializer.HardwareList.Clear();
        listInitializer.DesktopList.Clear();
        listInitializer.ProductsList.Clear();
        listInitializer.LaptopList.Clear();
    }

    [Test]
    public void TestSingleton()
    {
        var instance1 = ListInitializer.Instance;
        var instance2 = ListInitializer.Instance;
        Assert.That(instance1, Is.SameAs(instance2));
    }
    
    [Test]
    public void TestListInitializing()
    {
        Assert.That(listInitializer.HardwareList, Is.Not.Null);
        Assert.That(listInitializer.ProductsList, Is.Not.Null);
        Assert.That(listInitializer.DesktopList, Is.Not.Null);
        Assert.That(listInitializer.LaptopList, Is.Not.Null);
        Assert.That(listInitializer.AccessoriesList, Is.Not.Null);
        Assert.That(listInitializer.CartList, Is.Not.Null);
    }

    [Test]
    public void TestLoadProductsFromDatabase()
    {
        listInitializer.LoadProductsFromDatabase();
        Assert.That(listInitializer.ProductsList.Count(), Is.GreaterThan(0));
        Assert.That(listInitializer.HardwareList.Count(), Is.GreaterThan(0));
        Assert.That(listInitializer.DesktopList.Count(), Is.GreaterThan(0));
        Assert.That(listInitializer.LaptopList.Count(), Is.GreaterThan(0));
        Assert.That(listInitializer.AccessoriesList.Count(), Is.GreaterThan(0));
    }

    [Test]
    public void TestAddToCart()
    {
        listInitializer.LoadProductsFromDatabase(); // Check if Method accidentaly interferes with cartlist
        Assert.That(listInitializer.CartList.Count(), Is.EqualTo(0));
        listInitializer.CartList.Add(new Products());
        Assert.That(listInitializer.CartList.Count(), Is.EqualTo(1));
    }

    [Test]
    public void TestRemoveFromCart()
    {
        listInitializer.CartList.Add(new Products());
        Assert.That(listInitializer.CartList.Count(), Is.EqualTo(1));
        listInitializer.CartList.RemoveAt(0);
        Assert.That(listInitializer.CartList.Count(), Is.EqualTo(0));
    }
    
    [TearDown]
    public void TearDown()
    {
        Console.WriteLine("TearDown");
    }
}