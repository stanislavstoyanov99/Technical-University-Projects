public class User {
    private  String pass;
    private String username;

    public User(String pass, String username) {
        this.pass = pass;
        this.username = username;
    }

    public boolean authenticate() {
        if("secret".equals(this.pass) && "Grrrr".equals(this.username)) {
            return true;
        }
        else {
            return false;
        }
    }
}
