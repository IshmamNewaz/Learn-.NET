using AutoMapper;
using BLL.DTOs;
using DLL.EF;
using DLL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PetinfoService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Petinfo, PetinfoDTO>();
                cfg.CreateMap<PetinfoDTO, Petinfo>();
            });
            var mapper = new Mapper(config);
            return mapper;
        }

        public static void Create(PetinfoDTO c)
        {
            /*var repo = new CourseRepo();
            var mapper = GetMapper();
            var data = mapper.Map<Course>(c);
            repo.Create(data);*/

            new PetinfoRepo().Create(GetMapper().Map<Petinfo>(c));
        }

        public static List<PetinfoDTO> Get()
        {
            /*var data = new CourseRepo().Get();
            var ret = GetMapper().Map<List<CourseDTO>>(data);
            return ret;*/
            return GetMapper().Map<List<PetinfoDTO>>(new PetinfoRepo().Get());
        }
        public static List<PetinfoDTO> Get(string userId)
        {
            return GetMapper().Map<List<PetinfoDTO>>(new PetinfoRepo().GetByUserId(userId));
        }
        public static List<PetinfoDTO> GetX(string MatricId)
        {
            return GetMapper().Map<List<PetinfoDTO>>(new PetinfoRepo().GetMatricById(MatricId));
        }

        public static void Update(PetinfoDTO matsDto)
        {
            var repo = new PetinfoRepo();
            var mapper = GetMapper();
            var mats = mapper.Map<Petinfo>(matsDto);
            repo.Update(mats);
        }

        public static void Delete(string matricId)
        {
            var repo = new PetinfoRepo();
            repo.Delete(matricId);
        }
    }
}
