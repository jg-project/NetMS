using System;
using static Mango.Web.Utility.SD;

namespace Mango.Web.Models.Dto;

public class RequestDto
{
    public ApiType ApiType {get; set;} = ApiType.GET;
    public string Url {get; set;} = "GET";
    public object Data {get; set;} = "GET";
    public string AccessToken {get; set;} = "GET";


}
