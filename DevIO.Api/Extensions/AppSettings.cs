namespace DevIO.Api.Extensions {
    public class AppSettings {
        public string Secret { get; set; } //chave de criptografia
        public int ExpiracaoHoras { get; set; } //quantas horas que o token vai ficar válido.
        public string Emissor { get; set; } //quem emite o token
        public string ValidoEm { get; set; } //quais urls o esse token é válido
    }
}