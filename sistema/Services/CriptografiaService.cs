using Microsoft.AspNetCore.DataProtection;
using System.Security.Cryptography;
namespace ClinicaVeterinaria.Services;

public class CriptografiaService
{
    public const string CpfMascarado = "XXX-XXX-XXX-XX";
    private readonly IDataProtector _protetor;
    public CriptografiaService(IDataProtectionProvider provider)
    {
        _protetor = provider.CreateProtector("CPFTutor.v1");
    }
    public string Criptografar(string texto) => _protetor.Protect(texto);
    public string Descriptografar(string valor)
    {
        if (string.IsNullOrWhiteSpace(valor))
            return string.Empty;

        try
        {
            return _protetor.Unprotect(valor);
        }
        catch (CryptographicException)
        {

            return CpfMascarado;
        }
    }
}
