public class ContaBancaria
{
 // PRIVATE: só a classe acessa
 private string _titular;
 private double _saldo;
 private string _senha;
 private List<string> _extrato;

 // PUBLIC: interface externa
 public ContaBancaria ( string titular,
 double saldoInicial,string senha)

    {
    _titular = titular;
    _saldo = saldoInicial >= 0
    ? saldoInicial : 0;
    _senha = senha;
    _extrato = new List<string>();
    }

    public void Depositar(double valor)
    {
        if (valor <= 0) return;
        _saldo += valor;
        _extrato.Add(
        $"+R${valor:F2}");
    }
    public double ConsultarSaldo(string senha)
        {
        if (senha != _senha){
        return -1; // Negado
        return _saldo;}
        }
}