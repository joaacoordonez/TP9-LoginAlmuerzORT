using System.Data.SqlClient;
using Dapper;

static class BD{
    private static string _ConnectionString = @"Server=localhost; DataBase=-BD-AlmuerzORT; Trusted_Connection=True";
    
    public static bool UsuarioValido(Usuario user){
        string SQL = "SELECT COUNT(*) FROM Usuario WHERE dni = @pdni";
        using(SqlConnection db=new SqlConnection(_ConnectionString)){
            db.Execute(SQL,new(pdni = user.dni));
        }

        if(SQL < 1) return true;
        else return false;

    }
    public static void GuardarRegistro(Usuario user){
        string SQL = "INSERT INTO Usuarios(nombre, apellido, mail, usuario, contraseña) VALUES(@pnombre, @papellido, @pmail, @pusuario, @pcontraseña)";
        using(SqlConnection db=new SqlConnection(_ConnectionString)){
            db.Execute(SQL,new(pnombre = user.nombre, papellido = user.apellido, pmail=user.mail, pusuario=user.usuario, pcontraseña = user.contraseña));
        }
    }
}
