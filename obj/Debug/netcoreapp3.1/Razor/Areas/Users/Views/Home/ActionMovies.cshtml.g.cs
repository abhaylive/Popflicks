#pragma checksum "D:\prooject related data\project\Areas\Users\Views\Home\ActionMovies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "516582d7d6c940a1747a8d163d372116c76bb90b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Users_Views_Home_ActionMovies), @"mvc.1.0.view", @"/Areas/Users/Views/Home/ActionMovies.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\prooject related data\project\Areas\Users\Views\Home\_ViewImports.cshtml"
using project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\prooject related data\project\Areas\Users\Views\Home\_ViewImports.cshtml"
using project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"516582d7d6c940a1747a8d163d372116c76bb90b", @"/Areas/Users/Views/Home/ActionMovies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6489460591dedbaaa7ef634782f0f12b0f7a4e7", @"/Areas/Users/Views/Home/_ViewImports.cshtml")]
    public class Areas_Users_Views_Home_ActionMovies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\prooject related data\project\Areas\Users\Views\Home\ActionMovies.cshtml"
  
    ViewData["Title"] = "ActionMovies";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    body {
        background-image: url('data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxMTEhUTExMVFhUXGBcaGBcXGBcXGBcVFxUXFxcYFxcYHSggGBolHRUVITEhJSkrLi4uFx8zODMtNygtLisBCgoKDg0OFw8PFS0dFR0tLS0tLS0tLS0tKy0tLSstKy0tLS0tLS0tLS0tKy0tLS0tLS0tLS0tKystLS03LS0tLf/AABEIAKgBKwMBIgACEQEDEQH/xAAbAAACAgMBAAAAAAAAAAAAAAADBAIFAAEGB//EAEEQAAEDAgMECAQEBQIFBQAAAAEAAhEDIQQSMQVBUWEGEyJxgZGh8AcUscEyQtHhI1JysvEzYoKDorPCFSRTY3P/xAAXAQEBAQEAAAAAAAAAAAAAAAAAAQID/8QAGxEBAQEBAQEBAQAAAAAAAAAAAAERAjEhQRL/2gAMAwEAAhEDEQA/AOdqUUFzIT9UJSoFXIs9DRnBCIVVsORqbksAjUigcYmqTkpTKfwlOVEweiJTApqVHClNdTAUTC4orPl08ylAWOCGERQW+rTkrb6coEGtWxSTPUwVIqgDaS06mjZlHVEL5ChuYU7AUXIqvdTStdqtnNCVxFJEUrm3QnhP1qSScqqNKkdVKs6LKDqhQnVFQRr1J4zaFKFy2HEIGHUyhNpGVvrVjaiDZKlmC2+jKzqIQQdSlaFOEyGrYYgFS1Vvh6ciUjSpKxoGBCiVhChlRnKMIgDmSJSFYXVrhacghLYihCjorHGyWJTeICWyorQTFNqCAmaIKA1JqewjyCoYanKt8Ls6YKIcwpkaJwN4o+HwdlGrhyFlML1oS7pKYNArRpIB0qUpmrT0hZSEIjiTuRcK1UBzU8aJO5bGHRMVxYtZFYnDLRw6umK/KoEJ11MIbmBDChagVVZdSksWIVRU4wKtfT4qwxNkjUcqFq6G+nOim511FzlQs4G");
            WriteLiteral(@"YUsjoRWM3otNqoSkprDNvdbfSRKYuoLLDMBsnBs8nRQ2fTncrzCUwohGlsfio19mATG5XYbG9axDRGl1NHMCgmm04CbNGFBzVUKuYhEo72oRBQEwjTmWbTpQrBsBJbYrhYdsc/U1S70bEOCHTpErSIMarLCUSdyzCYIldRsjZ3EKWmBbO2cSJhXeHwkap+jQhUu1OlFGi99MteXstAAgngDNo4wsmLprVp1IFD2ZtGnWHYPaABLTq2dJTuRFwmaC0/Ap8UkVtKyGKj5SCmGYUJrqpKtKOEDRLteCmmKVmH5IdenFoV9VYFXV6aGKrq+CE+iVZ9UomiqYqHYdR+VVqaS11BRMVb6KSxWGsV0jMFKm7ZGbcrqY89xWDLkq/ZbuC9GqdHzuaVOnsOBdt1f6P5eT4nAkGEs+nwC9K290fDWZhE9115/jTkeQBC1LqYB1ZUqdMgKBrpjDyTAuqjGidU5hsFJsN6sNlbEc45iLLsMFslgAgSs2rjn8HgYCdbSXQYjCACzCFVvZJgXjWLx38DyU1MQo0xvW8UWxAuUYUToksTQy75lRfwhXKWLkTEkpFxK0yKQhklaLlsEKoi3E7gqvatU6I1V+UyktoPzHwWHelqZlXOzcCXaKuwNLMQu66P4C2iVJGtm7MAXS4LBclGvUoYWmatZ4a31c6CcrR+Zxg2HBVbfiTgg0kCqCNGllz4gkAd53dyz9rXx0gwi8T23iOsxdZ0RL3+hIH0XqXQXpe7HYjFNLWikzIaMNLXZS5wOeXGSYbpC8ixbv49Qz+d/8AcVqfKlek9BMP2qx3wz/yXYdSuF6EdJKFE1OucW9ZlLTEi2aQYvN16BT2thjhxiDVa2mZhz5ZdpIIh1yZBss3ViDGIgoylNm7Zw9eOqrU3EzDQ4Zra9k39NFZtbuUVGnhgLqm6Y7aOEwr6zWhxblABmCXODbxuvKvCIXJfEePkzm/D1lKbTbOCbb9NFZ6XwDAdN6DyWvdEvaGOax7mHM1ts8fiBzEzEAcl0NJzXi");
            WriteLiteral(@"WkESRPNpLT5EEeC8U2tRDaz2056trzlkZZiwcQAADGtgvWuh7T8nRm5IcTzJqPK11JGYs3MURSRi1Re2yxrWB9UApBgQxUTVBspqYJSZpAlPUf6YKnQZAutbQxjaNN1R85WiTGusfdGpBmW1W3EcF5x0W+IjquIGHr0xNWoQx7SGtYCBlZlIk3BvMkuC9AMpZhLKqekzWtouflnLfu5rxbHVGvcTv4le19KK3V4ao6x7JgG4JIgAjmvCH1L34rfDn2ao0GGJP+O9dt0b2dSeGloB3TF1wQxC7noNVF4mbeS1WI76jgGNEQFjqLBuCGK9kGriFzb1VdLsNWdQcMOf4pLRIJYQ2bkOBkeu+yT6P4J9CgKdZ4qPlxLwCJzGY8NJ3xKs8RXJSma6qDPhJYhs2TTmAXlI4rFCCiKnGthIxKPXqSVpjVtgE0lDImy1C6tBylWuZUcQ6UpUmVqpXvyR1WWynw8DmvU9m4/DUurZUrU2OqTkDnBuYtiQCbT2hbmvGXV4HZMHiNUo8CCSB74pedJceg/GHGkVqVPMerDGPDbxmLqozRpMCJ4Lz19YLeNqvc0Z3OcQYlxLiAAIAmYAk2Szjz9+avMxLXa/DTpThsFVqurlwa9jQC1pdBDpMgX0+i5Z9fNUc4byT5lVzj79lFw7voln6p8VtEzitoP7IlxaAQBNhmMnfbyVQHm3h9EzXqQd/n9lUQbjIHZFwd4G/x5L3j4X7e+awxa9sVaWUOMQHNdOU6m/ZM9y8GpMubHdv717F8FP9PEf8n6VFnvxrn16UaYXG/FZrRs91rmpTA5GSfoD5rsg1cL8XMSwYVlGe2+oHBv8Asa14Lu6SB4rlPW+vHkdEy6ea956IUG/JUP6T/c5eE0wAYjzsveeh9VpwOHdmAGWJ5hzgR5grfbPKwqUgq3EutdN4ysCbHT1SLrniubSNDDSrnDUA0c1HD4WADF05SCLgapumg/8AZV/6W/8Acauhyhc906dGCrdzP+6xEvjwh7nNqhzSQ4OBBGs");
            WriteLiteral(@"giIXvmxekVDF5+pJlh7QILTebid0gjwXgG0HdorqvhXtOoMcKYIyVGOziNera5zDO6CTpxXXqbNc+blekdOQPk6pJAjKZv/MBaN5mPFeJVS0nVepfFPauTDtoNPbquBLYn+G2ZM6DtBvqvHi3M4NzBoJuTYBOPE69PsoOvlEgAk8QBvK7D4cYlh6wT/EEQJN274Gmq5M46myg6nTc4uc+JIAHVNMtvxJiRyUeiFYtxdH/APWmDvs5wB9CtWfGXsFSoUItcdyfL28AhvrLm0TGHcdVgw43nyUqtYbkpUrHciMxRi0qsxZHGyJisVGt1S7Qxc71qJWVaolSZVVW6rKNQqKotmulalApVLKWdEcdUpxdVFWtcp2pWJEKpquuq6jB60yruN54bkMFb6uDfW3qJ+6IPtLEB7iQ0MBc4hrdG6AATJsN6VBPv/Kyp9z9loaKxA3n37JRsO7lxQHn37KnRP0Uqi5xIgDd6BExEZt27vSwNx4Jmo6/7fdBphH+3dvK9K+GO3ThaNd4pOqguYCGlrcsAw4udYC58wvNQ7v8ld0ca+ngXtY5zRUrBr4tma1geAd47QabRpwlLPix6zV+LWEA7NHEEwIBbTAk7pzmPJcB076X/PPpvbTNMMa5sF2aQSDJMCDM+i4w1jx9wivBKk5kLbTNGqZB019+i9g6LYs/I0WzoHyO+q8/deNUAYmbXvPPku52H0sZSZTpPpuytBzOaQTJcTYGLQeKncWPSsBh3VP1VzQ2cG3uSlOieNp16IqU5yS5oDhBkG8hXa543oFaqGiXEAc1sVBIEiSCRzAiT/1DzVR0nJhgHEk+EX9VyvTTaXU0cLwfSrgg3n/RcAZ5gJi2up6X7f8Ak6AqZcxc7IBmDYJa4zoZjLovHNs9KMRVBa+vUc07pABgyJDQBqAodKukNXEZWvPZZAaOENAnxifFctVrLc5c7WVMQSdTv+i7D4Yx/wCpNA06uof+gfquEzXVjgtqvw1QvZ+IscyZIID2RLSLhwsZWqy7v4s");
            WriteLiteral(@"bTy4tjHXa2gS0QLPe5wmdY7De6LLzd9adyPtutUc8Go8udlFy4uMSbS6/E+KQTmYU806e96tejBHzdGf/AJqP94VO3crfos2cXRH/AN1H6rV8T9ezVKwGgSdaqmsRSa0STJ4Kh2htAD8IuFyDZrXVJjeklAVvlzUHWSBlvqRmAmI0I371HE7XgEi53cybAea8tx7S/HPDS0uLzBfoXaX4S6w5kaLUhI9JxuLuqmo4kqrw20MVAD6TahDRLmvDS4ccrhruOlwUvtja720nDqatMuEBxywJIB7TXGNfMhVMdBTamqTANVRdCJdhiXEmHuAncLGOYmT48ld1HDRCiVcUG6IPz/JJV3IPWKooMQ6G9/spItTu0H3y8PqkyeaNpVGcFqtWzOJiJNgBFu5EptkE8j9EsQYQQLuyPH6rYdZQJ7I8fqsBsqI1Hae/up0uK02gX6EW4rYpFpIMSApVbARHO19/dLNF/JMneiICpu052/VHdjCKWVpIhzjrGrWAHv8AxeiA0Dl6IdXR37ce5AV+JcYzOLu8qba3IeSW4KQKosc5GltdLbyiNrGd5ulKx3yPOd5UqTr79fupVe8fC6uG4RpM/iqf3BdRQxwEsDhn/ERvDTYHzB8l410O6UuoQw9qncZZsCSDm79fNObe2+6o8vaS2WBhyyJbJsb3F1ys+uksx1W3Nss6x7nVGzchpcJsLCN0/dcH0o6UnFsoMNMU+pDwCHF2bPl1sIjJ6qlxFaSq6qffgtSM2jY0wY71XvcjY99xyt5FJF61GUmm/mi7UPbd3pVrro+0j/Ed/Ur+oLtZ8ub/AEj7pbMjbYIz24D6lLByTwOtd78VY9HXn5inBv1tP0VXTdonujj4r0zwqN+qXxHpdfajog3VNXrTKJisSTO7u396XGGdAceUDiToFiAdKiXHMfwtv4x9h/cuY6F7O+ZrV50yGd3+o+dePZK6/pE7qMOcpg5SXHTNMgz3mVU/DFzaNCvXfPbqMptAEue5rS4NY38zj1nodwVXA6o");
            WriteLiteral(@"OHLhW/HTPjULrtLQN1QNItpUYl+kOBd8k/EV7PeWBlMaUwag/FxflkHhffK6zamxDULcXVbNWnOWk0iOrOYOph2+rBLg4EQ4Niwk8r8Q8dNCkwPa4Of1hI/MMhy1GiIyvDpI3Oa7WZTTE+juIDMIwDg2bb3S4/VHfXJS2z6RFJrSPw02Nva4c8WnXRWGDwDnxDTHGDCqUm4qQarx2xwBMyhHZyusuArOvqTPHVbw1DMYHf6E/bVCK010JXRaw1jHSCZBa2OMG55Kse0n/ACFPOXAk6k8FHNuJRERgnZRpv47zPBbOF7/fgsJP831WhP8AN6pqpYRpGtvTRSxFAkyBu4hCeSN5U7/zDzQJA3TM2P7qHEd6E029/qgNTdf/ACpV2yCP1Qqfv3KK737lEL8FuFEuUqQk3VUR5MQddFKm65/Xmg1nCT38Ct03j3/lSizwVaHDvKsDiPLgqXC1BmHeU81/ks1YZygyZS9Q2RKeJAH4deJBP0UXOBHBQJY3Xz+qTKbxF/VKustoi3VExTpPiEJpRH1DmL8siSb6QeSILtU9vwSzCt16mYzESsYLoGGOT/R//Wpj/e1V7Sndh1Q2qwk6PB8pKDvxjTRMQ14/MCNeU6hb6RVP4gyOIAa02MdokzccBbvngqrH4oE2IkxF/dv0QeuaGxmsLAk8yT6knvJWcAel+0i/DAHVrQ0kmS68Zp/4vRWnw+2cxmzn4tri6sBWiTIokGCGNNmucGtcTqZG5cX0oxYcA1pmDf34BTwmJ6qlTLZALGioJgG1nxxEx3dwVxXTu2ziJ/1Xwbm+/XwuAuP6VSXtBOYHMQN4zESByJvHElWdXaTRuJO4cTH05rnsZVe6q0uMu7PcIKqR2zcUX4eiHTcvGcxD2tqk3/3DPBHcd67nbtRtBrHkGA8CGwCRldbu08l5JTxbwQHPOXMS1t8rHua2XATEGDP7q2xu2TXqOqPMEk9mSQ2TMNn8qmDoML0kJqNa5jQCQC6TbdMQrKptKgDBePJ36LiqThr");
            WriteLiteral(@"KLUqNJ/Fw+iuRHIPqk3RhTfFmkqJa3SPqpl3Gffgo0gzDvnSO9HAGhN958EPPwn34LCRxKDb3BCc4eytnLx9FKlUaDrxBEbjqgF14RazmAwCTzj91AU2AHU+i21gP83kFRIVWjfPp6KEt4+/Jb6pvA+SwsB3HwQbJYDZ30Ujkj8RzHcNwn9EDqxO/0UwL6HzQSNNpiCbnyuhuEGcx8ri1tSpOtFvfgpkE/lTQIU5E/VHpUBoNTxnwWNDhcBSDHzwHDVQaNIg8Pf8AlO4eABJ9Cl20ncQjsoO3u9FAR5bxmeR9wsYBF3AevooDBH+b0Cn8o7jbwRdKvBjUEcRf013JV88CnqmHO9yXOEn83vzVQu1l4JjnCPTwhuONvcLYwkaut4qwweJa1vZY4v0DQJJ/p4D9U0VvUDebDetGmMxjcUaq2CajonUgC0k6RO6dSoDF9YQHwNwPDSJ5KgfgfZU6bove36I4oDgVrqBpB/ZTQE1Rq3N4x9lI1QB+ae4fqmRQA/cqIF9RA9+/2QVeMNuZJn0H6qyDTGUEGBH7Kvxsl7Rvt5kyrRtRvfz0QJUaTmmDJO48R+33QACa3MfYK0dlItru71X7OINZxItBtPMDVAd7TN98a75MLHsOb6cxrHeo4pxzSNbgcgrHCvbUtAiJkag7oKBWm9Y5/NP0aeXVoJklwjUEntNH2/aW20mG4a2O4fogperHBbFKdFIBMUmcgOc28zPoopXqlo0+SfyA6a8JBnuj6IeUJoT6ocFrqx7hNupKBoFNABSC31SJ1B5LYpkIBdVy9FDIOCZAJ5BEaECmVvBDa4BxMcvfirB74BJ3BQothgB4X7zc/VAm0yXeA+/3RKbkzgz2ATqbnxMomcgzuP1QLtARG0k216MyVFKU8KDxTtLAN4ozAmKRUEGbPp8/RSds2nuny/dNUjPv1RhB9++CCmqYEcAlauFA3fRXlUD33qvxIV1FU6iYnLfhb6pSvQJ0BHjb0VjWCAQror6tF2WAPUxu49w8kGnQIMl");
            WriteLiteral(@"sq1USN8poH1ltCo9Sp5ZvHctPqRomgZp3jz5Kb6QAi/D7KTRHeouNx5+/NBWVQDWjdJ9B+qeZUH8oka6pLA3qE8j6lM1sziMmos47o4cyqCmpuDRPjbvSeyPxOOunqSnsoaCeAn03pHZeJDGuJ1keQ/coLU7jGhHHfY7+BRcPQt+EWJH6ekKlqbacZECCCPfNZT20/tWBB1ix3CR4ILys0nkRoRu/ZVmIxRDjZ3/CTE74hUr8Q47z5qOYoLDDAu0JndB08PNWjmubHYJB3gWH3WlilqwTPyK2au8ytrEERWHPyW+sW1iuIj1vIrXWhYsUEg9bDgtrFBFzARBW8nj3rFiDHU5ESVttO0SVtYgJTBCZpFYsUUw11kZrlixAek8b93viitqefJbWINPPvvPBIYjuWLECNZLErSxVEXO3qAM927msWII1KgHesY3edfp+60sQbKG93ZceR8ot75rFiKrsBTJLoMC0nf3Dh3qxBDRuAW1iqF8fXLWkfzDVUxKxYrBArC1YsVEgtrFiD//Z');
        background-repeat: no-repeat;
        background-size: cover;
    }

    h1 {
        color: floralwhite;
        text-decoration-style: solid;
        text-shadow: 5px 5px 20px #333;
    }

    img {
        border: 2px solid white;
        box-shadow: 5px 5px 20px grey;
    }
</style>

<h1>Action Movies</h1>
<hr />
");
#nullable restore
#line 28 "D:\prooject related data\project\Areas\Users\Views\Home\ActionMovies.cshtml"
 if (Model.Count() > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n");
#nullable restore
#line 32 "D:\prooject related data\project\Areas\Users\Views\Home\ActionMovies.cshtml"
         foreach (var movie in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\prooject related data\project\Areas\Users\Views\Home\ActionMovies.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"item m-4\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "516582d7d6c940a1747a8d163d372116c76bb90b13659", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 38 "D:\prooject related data\project\Areas\Users\Views\Home\ActionMovies.cshtml"
                          
                            var base64 = Convert.ToBase64String(movie.Banner);
                            var imgsrc = string.Format("data:image/jpg; base64,{0}", base64);
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <img");
                BeginWriteAttribute("src", " src=\"", 8708, "\"", 8721, 1);
#nullable restore
#line 42 "D:\prooject related data\project\Areas\Users\Views\Home\ActionMovies.cshtml"
WriteAttributeValue("", 8714, imgsrc, 8714, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"200\" height=\"260\"");
                BeginWriteAttribute("title", " title=", 8747, "", 8765, 1);
#nullable restore
#line 42 "D:\prooject related data\project\Areas\Users\Views\Home\ActionMovies.cshtml"
WriteAttributeValue("", 8754, movie.Name, 8754, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "D:\prooject related data\project\Areas\Users\Views\Home\ActionMovies.cshtml"
                                             WriteLiteral(movie.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 45 "D:\prooject related data\project\Areas\Users\Views\Home\ActionMovies.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"item m-4\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "516582d7d6c940a1747a8d163d372116c76bb90b17372", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 50 "D:\prooject related data\project\Areas\Users\Views\Home\ActionMovies.cshtml"
                          
                            var base64 = Convert.ToBase64String(movie.Banner);
                            var imgsrc = string.Format("data:image/jpg; base64,{0}", base64);
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <img");
                BeginWriteAttribute("src", " src=\"", 9255, "\"", 9268, 1);
#nullable restore
#line 54 "D:\prooject related data\project\Areas\Users\Views\Home\ActionMovies.cshtml"
WriteAttributeValue("", 9261, imgsrc, 9261, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"200\" height=\"260\"");
                BeginWriteAttribute("title", " title=", 9294, "", 9312, 1);
#nullable restore
#line 54 "D:\prooject related data\project\Areas\Users\Views\Home\ActionMovies.cshtml"
WriteAttributeValue("", 9301, movie.Name, 9301, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 57 "D:\prooject related data\project\Areas\Users\Views\Home\ActionMovies.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "D:\prooject related data\project\Areas\Users\Views\Home\ActionMovies.cshtml"
             


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 62 "D:\prooject related data\project\Areas\Users\Views\Home\ActionMovies.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>No Movies Available In This Category</h3>\r\n");
#nullable restore
#line 66 "D:\prooject related data\project\Areas\Users\Views\Home\ActionMovies.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591