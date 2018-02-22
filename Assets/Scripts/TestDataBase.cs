﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite; 
using System.Data;

public class TestDataBase : MonoBehaviour {




	void connectToDataBase(){
		string conn = "URI=file:" + Application.dataPath + "/basenodos.db"; //Path to database.
     IDbConnection dbconn;
     dbconn = (IDbConnection) new SqliteConnection(conn);
     dbconn.Open(); //Open connection to the database.
     IDbCommand dbcmd = dbconn.CreateCommand();
     string sqlQuery = "SELECT idnodoorigen,idnodoinfluenciado " + "FROM influenciasnodos";
     dbcmd.CommandText = sqlQuery;
     IDataReader reader = dbcmd.ExecuteReader();
     while (reader.Read())
     {
         int idnodoorigen = reader.GetInt32(0);
         //string name = reader.GetString(1);
         int idnodoinfluenciado = reader.GetInt32(1);
        
         Debug.Log( "idnodoorigin= "+idnodoorigen+"  idnodoinfluenciado ="+idnodoinfluenciado);
     }
     reader.Close();
     reader = null;
     dbcmd.Dispose();
     dbcmd = null;
     dbconn.Close();
     dbconn = null;
	}


	// Use this for initialization
	void Start () {
		connectToDataBase();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
