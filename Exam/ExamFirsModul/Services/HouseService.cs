using ExamFirsModul.Models;
using System;
using System.Collections.Generic;




internal class HouseService
{
    private List<House> houses;

    public HouseService()
    {
        houses = new List<House>();
    }
    public House AddHouse(House house)
    {
        houses.Add(house);
        return house;

    }
    public House GetById(Guid Id)
    {
        foreach (House house in houses)
        {
            if (house.Id == Id)
            {
                return house;
            }
        }
        return null;
    }
    public bool Delete(Guid deletedHouse)
    {
        var houseDb = GetById(deletedHouse);
        if (houseDb.Id == deletedHouse)
        {
            houses.Remove(houseDb);
            return true;
        }
        return false;
    }
    public bool Update(House house)
    {
        var houseDb = GetById(house.Id);
        if (houseDb is null)
        {
            return true;
        }
        var index = houses.IndexOf(houseDb);
        houses[index] = house;
        return true;
    }
    public House GetAll(House houses)
    {
        return houses;
    }
}
