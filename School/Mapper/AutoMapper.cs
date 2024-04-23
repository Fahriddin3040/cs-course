using AutoMapper;
using School.Models;
using School.dto;

namespace School.Mapper;

public class MappingProfile : Profile
{
	public MappingProfile()
	{
		CreateMap<Teacher, TeacherCreateDTO>();
		CreateMap<Teacher, TeacherShortDTO>()
			.ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));
		CreateMap<TeacherCreateDTO, Teacher>();
		CreateMap<TeacherShortDTO, Teacher>();
		CreateMap<Student, StudentCreateDTO>();
		CreateMap<StudentCreateDTO, Student>();
		CreateMap<StudentUpdateDTO, Student>();
		CreateMap<Student, StudentUpdateDTO>();
		
		// CreateMap<GroupCreateDTO, Group>();
		// CreateMap<GroupUpdateDTO, Group>();
		// CreateMap<StudentCreateDTO, Student>();
		// CreateMap<StudentUpdateDTO, Student>();
		// CreateMap<SubjectCreateDTO, Subject>();
		// CreateMap<SubjectUpdateDTO, Subject>();
		// CreateMap<TeacherSubjectCreateDTO, TeachersSubjects>();
		// CreateMap<TeacherSubjectUpdateDTO, TeachersSubjects>();
		// CreateMap<StudentGroupCreateDTO, StudentGroup>();
		// CreateMap<StudentGroupUpdateDTO, StudentGroup>();
		// CreateMap<StudentSubjectCreateDTO, StudentsSubjects>();
		// CreateMap<StudentSubjectUpdateDTO, StudentsSubjects>();
		// CreateMap<UserCreateDTO, User>();
		// CreateMap<UserUpdateDTO, User>();
		// CreateMap<Teacher, TeacherDTO>();
		// CreateMap<Group, GroupDTO>();
		// CreateMap<Student, StudentDTO>();
		// CreateMap<Subject, SubjectDTO>();
		// CreateMap<TeachersSubjects, TeacherSubjectDTO>();
		// CreateMap<StudentGroup, StudentGroupDTO>();
		// CreateMap<StudentsSubjects, StudentSubjectDTO>();
		// CreateMap<User, UserDTO>();
	}
}