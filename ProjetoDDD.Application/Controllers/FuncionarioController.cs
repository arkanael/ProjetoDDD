using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProjetoDDD.Application.Models;
using ProjetoDDD.Application.Models.Funcionario;

namespace ProjetoDDD.Application.Controllers
{
    [RoutePrefix("/api/funcionario")]
    public class FuncionarioController : ApiController
    {
        
        [HttpPost]
        [Route("cadastrar")]
        public HttpResponseMessage Post(FuncionarioModelCadastro model)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    ///<summary>
                    ///Se a model passar pelas as validações retorna a resposta da requisição com o http com codigo do status Ok 200
                    /// </summary>
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    ///<summary>
                    ///Se a model não passar pelas as validações retorna a resposta da requisição com o http com codigo do status de requisição inválida 400
                    /// </summary>
                    return Request.CreateResponse(HttpStatusCode.BadRequest);

                }
            }
            catch (Exception e)
            {
                ///<summary>
                ///Se cair na exeption retorna a resposta da requisição com o http com codigo do status de erro interno do servidor 500
                /// </summary>
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);

            }
        }

        [HttpPut]
        [Route("atualizar")]
        public HttpResponseMessage Put(FuncionarioModelEdicao model)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    ///<summary>
                    ///Se a model passar pelas as validações retorna a resposta da requisição com o http com codigo do status Ok 200
                    /// </summary>
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    ///<summary>
                    ///Se a model não passar pelas as validações retorna a resposta da requisição com o http com codigo do status de requisição inválida 400
                    /// </summary>
                    return Request.CreateResponse(HttpStatusCode.BadRequest);

                }
            }
            catch (Exception e)
            {
                ///<summary>
                ///Se cair na exeption retorna a resposta da requisição com o http com codigo do status de erro interno do servidor 500
                /// </summary>
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);

            }
        }

        [HttpDelete]
        [Route("excluir")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    ///<summary>
                    ///Se a model passar pelas as validações retorna a resposta da requisição com o http com codigo do status Ok 200
                    /// </summary>
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    ///<summary>
                    ///Se a model não passar pelas as validações retorna a resposta da requisição com o http com codigo do status de requisição inválida 400
                    /// </summary>
                    return Request.CreateResponse(HttpStatusCode.BadRequest);

                }
            }
            catch (Exception e)
            {
                ///<summary>
                ///Se cair na exeption retorna a resposta da requisição com o http com codigo do status de erro interno do servidor 500
                /// </summary>
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);

            }
        }

        [HttpGet]
        [Route("obtertodos")]
        public HttpResponseMessage GetAll()
        {
            try
            {

                if (ModelState.IsValid)
                {
                    ///<summary>
                    ///Se a model passar pelas as validações retorna a resposta da requisição com o http com codigo do status Ok 200
                    /// </summary>
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    ///<summary>
                    ///Se a model não passar pelas as validações retorna a resposta da requisição com o http com codigo do status de requisição inválida 400
                    /// </summary>
                    return Request.CreateResponse(HttpStatusCode.BadRequest);

                }
            }
            catch (Exception e)
            {
                ///<summary>
                ///Se cair na exeption retorna a resposta da requisição com o http com codigo do status de erro interno do servidor 500
                /// </summary>
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);

            }
        }

        [HttpGet]
        [Route("obter")]
        public HttpResponseMessage Get()
        {
            try
            {

                if (ModelState.IsValid)
                {
                    ///<summary>
                    ///Se a model passar pelas as validações retorna a resposta da requisição com o http com codigo do status Ok 200
                    /// </summary>
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    ///<summary>
                    ///Se a model não passar pelas as validações retorna a resposta da requisição com o http com codigo do status de requisição inválida 400
                    /// </summary>
                    return Request.CreateResponse(HttpStatusCode.BadRequest);

                }
            }
            catch (Exception e)
            {
                ///<summary>
                ///Se cair na exeption retorna a resposta da requisição com o http com codigo do status de erro interno do servidor 500
                /// </summary>
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);

            }
        }
    }
}
