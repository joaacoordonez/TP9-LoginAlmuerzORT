public class Usuario{
    public int id_usuario {get; private set;}
    public string nombre {get; private set;}
    public string apellido {get; private set;}
    public string mail {get; private set;}
    public string usuario {get; set;}
    private string contraseña {get; set;}


    Usuario(){}

    Usuario(string nom, string ap, string mai, string us, string con){
        nombre = nom;
        apellido = ap;
        mail = mai;
        usuario = us;
        contraseña = con;
    }

}
