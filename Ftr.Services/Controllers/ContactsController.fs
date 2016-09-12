namespace Ftr.Services.Controllers

open System.Web.Http
open Ftr.Services.Models
open Ftr.Services.Repositories

type ContactsController(repository : ContactsRepository) =
    inherit ApiController()

    new() = new ContactsController(new ContactsRepository())

    member x.Get() = 
        repository.GetAll()

    member x.Post ([<FromBody>] contact) =    
        repository.AddNew(contact)