package net.codejava.hibernate.models;

import javax.persistence.*;

// POJO - Plain Old Java Object
@Entity
@Table(name = "USERS")
public class User {
    private Integer id;
    private String fullname;
    private String email;
    private String password;

    @Column(name="USER_ID")
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getFullname() {
        return fullname;
    }

    public void setFullname(String fullname) {
        this.fullname = fullname;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }
}
