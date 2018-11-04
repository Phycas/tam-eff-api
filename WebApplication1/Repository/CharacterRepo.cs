using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class CharacterRepo
    {
        private CharContext db = new Models.CharContext();

        public IQueryable<Models.Character> GetCharacters()
        {
            return db.Characters;
        }

        public Character AddCharacter(Character character)
        {
            try
            {
                db.Characters.Add(character);
                db.SaveChanges();
            }
            catch (Exception ex){
                string msg = ex.Message;
                throw ;
            }

            return character;
        }

        public Character GetCharacter(int id)
        {
            if(id == null)
            {
                return null;
            }
            Character character = db.Characters.Find(id);
           
            return character;
        }

        public Character RemoveCharacter(int id)
        {
            Character character = db.Characters.Find(id);
            if (character == null)
            {
                return null;
            }

            db.Characters.Remove(character);
            db.SaveChanges();

            return character;
        }

        public bool CharacterExists(int id)
        {
            return db.Characters.Count(e => e.Id == id) > 0;
        }

    }
}