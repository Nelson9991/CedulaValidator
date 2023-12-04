using System.Text.Json.Serialization;

namespace CedulaValidator.Shared.Dtos;

public class Addit
{
  [JsonPropertyName("nombreFantasiaComercial")]
  public string NombreFantasiaComercial { get; set; } = string.Empty;

  [JsonPropertyName("tipoEstablecimiento")]
  public string TipoEstablecimiento { get; set; } = string.Empty;

  [JsonPropertyName("direccionCompleta")]
  public string DireccionCompleta { get; set; } = string.Empty;

  [JsonPropertyName("estado")]
  public string Estado { get; set; } = string.Empty;

  [JsonPropertyName("numeroEstablecimiento")]
  public string NumeroEstablecimiento { get; set; } = string.Empty;

  [JsonPropertyName("matriz")]
  public string Matriz { get; set; } = string.Empty;
}

public class DataRuc
{
  [JsonPropertyName("main")]
  public List<Main> Main { get; set; } = new();

  [JsonPropertyName("addit")]
  public List<Addit> Addit { get; set; } = new();
}

public class InformacionFechasContribuyente
{
  [JsonPropertyName("fechaInicioActividades")]
  public string FechaInicioActividades { get; set; } = string.Empty;

  [JsonPropertyName("fechaCese")]
  public string FechaCese { get; set; } = string.Empty;

  [JsonPropertyName("fechaReinicioActividades")]
  public string FechaReinicioActividades { get; set; } = string.Empty;

  [JsonPropertyName("fechaActualizacion")]
  public string FechaActualizacion { get; set; } = string.Empty;
}

public class Main
{
  [JsonPropertyName("numeroRuc")]
  public string NumeroRuc { get; set; } = string.Empty;

  [JsonPropertyName("razonSocial")]
  public string RazonSocial { get; set; } = string.Empty;

  [JsonPropertyName("estadoContribuyenteRuc")]
  public string EstadoContribuyenteRuc { get; set; } = string.Empty;

  [JsonPropertyName("actividadEconomicaPrincipal")]
  public string ActividadEconomicaPrincipal { get; set; } = string.Empty;

  [JsonPropertyName("tipoContribuyente")]
  public string TipoContribuyente { get; set; } = string.Empty;

  [JsonPropertyName("regimen")]
  public string Regimen { get; set; } = string.Empty;

  [JsonPropertyName("categoria")]
  public object Categoria { get; set; } = string.Empty;

  [JsonPropertyName("obligadoLlevarContabilidad")]
  public string ObligadoLlevarContabilidad { get; set; } = string.Empty;

  [JsonPropertyName("agenteRetencion")]
  public string AgenteRetencion { get; set; } = string.Empty;

  [JsonPropertyName("contribuyenteEspecial")]
  public string ContribuyenteEspecial { get; set; } = string.Empty;

  [JsonPropertyName("informacionFechasContribuyente")]
  public InformacionFechasContribuyente InformacionFechasContribuyente { get; set; } = new();

  [JsonPropertyName("representantesLegales")]
  public object RepresentantesLegales { get; set; } = string.Empty;

  [JsonPropertyName("motivoCancelacionSuspension")]
  public object MotivoCancelacionSuspension { get; set; } = string.Empty;

  [JsonPropertyName("contribuyenteFantasma")]
  public string ContribuyenteFantasma { get; set; } = string.Empty;

  [JsonPropertyName("transaccionesInexistente")]
  public string TransaccionesInexistente { get; set; } = string.Empty;
}

public class RucResponseDto
{
  [JsonPropertyName("data")]
  public DataRuc? Data { get; set; }
}
