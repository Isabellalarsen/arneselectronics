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
    }

    [Test]
    public void TestProductList()
    {
        Assert.That(listInitializer.ProductsList, Is.Not.Null);
    }

    [Test]
    public void TestLoadProductsFromDatabase()
    {
        listInitializer.LoadProductsFromDatabase();
        Assert.That(listInitializer.ProductsList.Count(), Is.GreaterThan(0));
    }

    [TearDown]
    public void TearDown()
    {
        Console.WriteLine("TearDown");
    }
}