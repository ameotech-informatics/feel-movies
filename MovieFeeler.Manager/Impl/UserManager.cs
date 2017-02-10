using MovieFeeler.Common;
using MovieFeeler.DAO;
using MovieFeeler.DAO.Impl;
using MovieFeeler.DAO.Interfaces;
using MovieFeeler.Manager.Interfaces;
using MovieFeeler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFeeler.Manager.Imp
{
    public class UserManager : IUserManager
    {
        private IRepository<User> _userRepo;
        public UserManager()
        {
            _userRepo = new Repository<User>();

        }
        public void Register(User user)
        {
            try
            {
                var isExistUsername = _userRepo.IsExist(x => x.username == user.username);
                var isExistsEmail =_userRepo.IsExist(x=>x.email==user.email);
                if (isExistUsername)
                {
                    throw new AlreadyExistException("Username already exist.");
                }

                else if(isExistsEmail)
                {
                     throw new AlreadyExistException("Email already exist.");
                }
                else
                {
                    var encriptedPasword = EncryptExtension.EncryptMD5(user.password);
                    user.password = encriptedPasword;
                    _userRepo.Add(user);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public bool Login(string username, string password)
        {
             var encriptedPasword = EncryptExtension.EncryptMD5(password);
              return  _userRepo.IsExist(x => x.username == username && x.password == encriptedPasword);
             
        }


    }
}
