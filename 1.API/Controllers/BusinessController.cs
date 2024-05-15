using _1.API.Request;
using _2._Domain;
using _3._Data;
using _3._Data.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _1.API.Controllers;


[Route("api/")]
[ApiController]
public class BusinessController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IClientData _clientData;
    private readonly IClientDomain _clientDomain;
    private readonly IShoesData _shoesData;
    private readonly IShoesDomain _shoestDomain;
    
    public BusinessController(IMapper mapper,IClientData clientData,IClientDomain clientDomain,IShoesData shoesData,IShoesDomain shoesDomain)
    {
        _mapper = mapper;
        _clientData = clientData;
        _clientDomain = clientDomain;
        _shoesData = shoesData;
        _shoestDomain = shoesDomain;
    }
    
    [Route("membership/status")]
    [HttpGet]
    public List<String> GetClientsStatus()
    {
        return _clientData.GetAllClientNames(_clientData.getAll());
    }
    
    [Route("shoe/brands")]
    [HttpGet]
    public List<String> GetShoesBrands()
    {
        return _shoesData.GetShoesBrands(_shoesData.getAll());
    }
    
    [Route("shoe/seasons")]
    [HttpGet]
    public List<String> GetShoesSeasons()
    {
        return _shoesData.GetShoesSeasons(_shoesData.getAll());
    }

    [Route("discount/check")]
    [HttpPost]
    public Double Post([FromBody] PriceRequest price)
    {
        // Crear una lista de cadenas y agregar las propiedades del objeto PriceRequest
        List<string> listaDatos = new List<string>();

        // Agregar cada propiedad a la lista de cadenas
        listaDatos.Add(price.price);
        listaDatos.Add(price.membershipStatus);
        listaDatos.Add(price.shoeBrand);
        listaDatos.Add(price.shoeSeason);
    
        return  _shoestDomain.CalculateFinalPrice(listaDatos);
    }

    
}