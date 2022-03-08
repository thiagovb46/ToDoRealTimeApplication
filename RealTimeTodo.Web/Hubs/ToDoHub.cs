using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

public class ToDoHub: Hub{

    private  readonly IToDoRepository toDoRepository;
     public ToDoHub(IToDoRepository toDoRepository)
     {
         this.toDoRepository = toDoRepository;
     }
     public Task<List<ToDoList>> GetLists(){
         return toDoRepository.GetLists();
     }

    
}