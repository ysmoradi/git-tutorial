using MyCompany.MyApp.Server.Api.Models.TodoItem;
using MyCompany.MyApp.Shared.Dtos.TodoItem;

namespace MyCompany.MyApp.Server.Api.Mappers;

public class TodoItemMapperConfiguration : Profile
{
    public TodoItemMapperConfiguration()
    {
        CreateMap<TodoItem, TodoItemDto>().ReverseMap();
    }
}
