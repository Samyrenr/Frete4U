using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestPage.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Display(Name = "Lembrar dados")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "*Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve ter pelo menos {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "*Senha")]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "*Confirmar senha")]
        [Compare("Senha", ErrorMessage = "As senhas informadas não são iguais.")]
        public string ConfirmarSenha { get; set; }

        [Required]
        [Display(Name = "Tipo de Cadastro")]
        public int TipoCadastro { get; set; }

        [Required]
        [Display(Name = "*Nome Completo")]
        public string NomePessoa { get; set; }

        [Required]
        [Display(Name = "Nome da empresa")]
        public string NomeEmpresa { get; set; }

        [Display(Name = "*CPF")]
        public int CPF { get; set; }

        [Display(Name = "*CNPJ")]
        public int CNPJ { get; set; }

        [Display(Name = "*Telefone 1")]
        public string Telefone1 { get; set; }

        [Display(Name = "Telefone 2")]
        public string Telefone2 { get; set; }

        // Endereço

        [Display(Name = "*CEP")]
        public int CEP { get; set; }

        [Display(Name = "*Rua")]
        public int Rua { get; set; }

        [Display(Name = "*Número")]
        public string NumeroEnd { get; set; }

        [Display(Name = "Complemento")]
        public string Complemento { get; set; }

        [Display(Name = "*Bairro")]
        public int Bairro { get; set; }

        [Display(Name = "*Cidade")]
        public string Cidade { get; set; }

        [Display(Name = "*UF")]
        public string UF { get; set; }

    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
