﻿using EcomerceApp.Models;

namespace EcomerceApp.Data.Services
{
    public interface IActorsService
    {
        IEnumerable<Actor> GetAll();
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);
    }
}
