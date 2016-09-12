namespace Ftr.Services.Controllers

open System.Web.Http
open System
open System.Collections.Generic
open System.Linq
open System.Web
open System.Web.Mvc
open System.Web.Mvc.Ajax
open Ftr.Services.Models
open Ftr.Services.Repositories

type ContactsController(repository : ContactsRepository) =
    //inherit ApiController()
    inherit Controller()
    
    new() = new ContactsController(new ContactsRepository())

    member this.Index () = 
        let contacts = repository.GetAll()
        this.View()

    

//    member x.Get() = 
//        repository.GetAll()

    member x.Post ([<FromBody>] contact) =    
        repository.AddNew(contact)