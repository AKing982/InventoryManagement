import React, {useState} from "react";
import {Grid, TextField} from "@mui/material";
import {Button} from "reactstrap";

interface LoginProps{
    
}

const Login: React.FC<LoginProps> = (props) => {
    const [username, setUserName] = useState<string>("");
    const [password, setPassword] = useState<string>("");
    
    const login = async () => {
        const result = await fetch("/login", {
            method: "POST",
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                username,
                password, 
            }),
        });
        
        const body = await result.json();
        if(result.ok)
        {
            
        }
        else
        {
            
        }
        
    }
    return (
        <Grid container direction="column" justifyContent="center" alignItems="center">
            <Grid item>
                <TextField
                    label="Username"
                    variant="outlined"
                    value={username}
                    onChange={e => setUserName(e.target.value)}
                />
            </Grid>
            <Grid item>
                <TextField
                    label="Password"
                    type="password"
                    variant="outlined"
                    value={password}
                    onChange={e => setPassword(e.target.value)}
                />
            </Grid>
            <Grid item>
                <Button variant="contained" color="primary" onClick={login}>
                    Login
                </Button>
            </Grid>
        </Grid>
    );
    
}

export default Login;