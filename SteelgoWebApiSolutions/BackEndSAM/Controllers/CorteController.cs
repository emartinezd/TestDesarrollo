﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Script.Serialization;
using BackEndSAM.DataAcces;
using BackEndSAM.Models;
using CommonTools.Libraries.Strings.Security;
using DatabaseManager.Sam3;
using SecurityManager.Api.Models;
using SecurityManager.TokenHandler;

namespace BackEndSAM.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CorteController :ApiController
    {

        //public object Get(string data)
        //{
        //    JavaScriptSerializer serializer = new JavaScriptSerializer();
        //    ParametrosBusquedaODT filtros = serializer.Deserialize<ParametrosBusquedaODT>(data);
        //    string payload = "";
        //    string newToken = "";
        //    bool tokenValido = ManageTokens.Instance.ValidateToken(filtros.DatosODT.token, out payload, out newToken);
        //    if (tokenValido)
        //    {
                
        //        Sam3_Usuario usuario = serializer.Deserialize<Sam3_Usuario>(payload);
        //        return CorteBd.Instance.ListadoGenerarCorte(filtros, usuario);
        //    }
        //    else
        //    {
        //        TransactionalInformation result = new TransactionalInformation();
        //        result.ReturnMessage.Add(payload);
        //        result.ReturnCode = 401;
        //        result.ReturnStatus = false;
        //        result.IsAuthenicated = false;
        //        return result;
        //    }
        //}

        
        public object Post(GuardarCorte cortes, string token)
        {
            string payload = "";
            string newToken = "";
            bool tokenValido = ManageTokens.Instance.ValidateToken(token, out payload, out newToken);
            if (tokenValido)
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                Sam3_Usuario usuario = serializer.Deserialize<Sam3_Usuario>(payload);
                return CorteBd.Instance.GenerarCorte(cortes, usuario);
            }
            else
            {
                TransactionalInformation result = new TransactionalInformation();
                result.ReturnMessage.Add(payload);
                result.ReturnCode = 401;
                result.ReturnStatus = false;
                result.IsAuthenicated = false;
                return result;
            }
        }

        public object Get(int materialSpoolID, string token)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string payload = "";
            string newToken = "";
            bool tokenValido = ManageTokens.Instance.ValidateToken(token, out payload, out newToken);
            if (tokenValido)
            {

                Sam3_Usuario usuario = serializer.Deserialize<Sam3_Usuario>(payload);
                return CorteBd.Instance.ListadoCorteDesdeImpresion(materialSpoolID, usuario);
            }
            else
            {
                TransactionalInformation result = new TransactionalInformation();
                result.ReturnMessage.Add(payload);
                result.ReturnCode = 401;
                result.ReturnStatus = false;
                result.IsAuthenicated = false;
                return result;
            }
        }

        public object Delete(int corteDetalleID, string token)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string payload = "";
            string newToken = "";
            bool tokenValido = ManageTokens.Instance.ValidateToken(token, out payload, out newToken);
            if (tokenValido)
            {

                Sam3_Usuario usuario = serializer.Deserialize<Sam3_Usuario>(payload);
                return CorteBd.Instance.EliminarCorte(corteDetalleID, usuario);
            }
            else
            {
                TransactionalInformation result = new TransactionalInformation();
                result.ReturnMessage.Add(payload);
                result.ReturnCode = 401;
                result.ReturnStatus = false;
                result.IsAuthenicated = false;
                return result;
            }
        }

        public object Get(string numeroUnico, string token)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string payload = "";
            string newToken = "";
            bool tokenValido = ManageTokens.Instance.ValidateToken(token, out payload, out newToken);
            if (tokenValido)
            {
                Sam3_Usuario usuario = serializer.Deserialize<Sam3_Usuario>(payload);

                string[] elementos = numeroUnico.Split('-').ToArray();

                string prefijo = elementos[0];
                int consecutivo = 0;
                int.TryParse(elementos[1], out consecutivo);
                string segmento = elementos[2];

                return CorteBd.Instance.ListadoNumerosDeControl(prefijo, consecutivo, usuario);
            }
            else
            {
                TransactionalInformation result = new TransactionalInformation();
                result.ReturnMessage.Add(payload);
                result.ReturnCode = 401;
                result.ReturnStatus = false;
                result.IsAuthenicated = false;
                return result;
            }
        }

        public object Get(string numeroControl, string etiqueta, string token)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string payload = "";
            string newToken = "";
            bool tokenValido = ManageTokens.Instance.ValidateToken(token, out payload, out newToken);
            if (tokenValido)
            {
                Sam3_Usuario usuario = serializer.Deserialize<Sam3_Usuario>(payload);
                return CorteBd.Instance.ObtenerCantidadMaterial(numeroControl, etiqueta, usuario);
            }
            else
            {
                TransactionalInformation result = new TransactionalInformation();
                result.ReturnMessage.Add(payload);
                result.ReturnCode = 401;
                result.ReturnStatus = false;
                result.IsAuthenicated = false;
                return result;
            }
        }
    }
}