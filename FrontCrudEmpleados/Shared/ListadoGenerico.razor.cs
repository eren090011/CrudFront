using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using FrontCrudEmpleados.Shared;
namespace FrontCrudEmpleados.Shared
{
    public partial class ListadoGenerico<Titem>
    {
        [Parameter]
        public RenderFragment Cargando { get; set; } = null;

        [Parameter]
        public RenderFragment NoHayRegistros { get; set; } = null;

        [Parameter]
        public RenderFragment<Titem> HayRegistros { get; set; } = null;

        [Parameter]
        public RenderFragment HayRegistrosCompleto { get; set; } = null;

        [Parameter]
        [EditorRequired]
        public List<Titem> Listado { get; set; } = null;
    }
}
