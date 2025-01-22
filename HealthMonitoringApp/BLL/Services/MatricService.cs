using AutoMapper;
using BLL.DTOs;
using DAL.EF;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MatricService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Matric, MatricDTO>();
                cfg.CreateMap<MatricDTO, Matric>();
            });
            var mapper = new Mapper(config);
            return mapper;
        }

        public static void Create(MatricDTO c)
        {
            /*var repo = new CourseRepo();
            var mapper = GetMapper();
            var data = mapper.Map<Course>(c);
            repo.Create(data);*/

            new MatricRepo().Create(GetMapper().Map<Matric>(c));
        }

        public static List<MatricDTO> Get()
        {
            /*var data = new CourseRepo().Get();
            var ret = GetMapper().Map<List<CourseDTO>>(data);
            return ret;*/
            return GetMapper().Map<List<MatricDTO>>(new MatricRepo().Get());
        }
        public static List<MatricDTO> Get(string userId)
        {
            return GetMapper().Map<List<MatricDTO>>(new MatricRepo().GetByUserId(userId));
        }
        public static List<MatricDTO> GetX(string MatricId)
        {
            return GetMapper().Map<List<MatricDTO>>(new MatricRepo().GetMatricById(MatricId));
        }

        public static void Update(MatricDTO matsDto)
        {
            var repo = new MatricRepo();
            var mapper = GetMapper();
            var mats = mapper.Map<Matric>(matsDto); 
            repo.Update(mats); 
        }

        public static void Delete(string matricId)
        {
            var repo = new MatricRepo();
            repo.Delete(matricId); 
        }
    }
}
