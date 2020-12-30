/*
 * Certifications
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2a4401b7-a9c4-4cac-ac91-0da3771d5bf7
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class DefaultApiController : ControllerBase
    { 
        /// <summary>
        /// Add Certification Step 1
        /// </summary>
        /// <remarks>First step of applying for certifice.</remarks>
        /// <param name="body"></param>
        /// <response code="200"></response>
        [HttpPost]
        [Route("/laravel/api/certification/add_certification")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("AddCertificationStep1")]
        public virtual IActionResult AddCertificationStep1([FromBody]Body body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Add certification_exam_info Step 2
        /// </summary>
        /// <remarks>Second step of applying for certifice.</remarks>
        /// <param name="body"></param>
        /// <response code="200"></response>
        [HttpPost]
        [Route("/laravel/api/certification/certification_exam_info")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("AddcertificationExamInfoStep2")]
        public virtual IActionResult AddcertificationExamInfoStep2([FromBody]string body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// All Certifications Schemes
        /// </summary>
        /// <remarks>Returns an array of certification schemes objects with its relevant certification levels data.</remarks>
        /// <response code="200"></response>
        [HttpGet]
        [Route("/laravel/api/certification/allCertifications")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("AllCertificationsSchemes")]
        public virtual IActionResult AllCertificationsSchemes()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Billing History
        /// </summary>
        /// <remarks>Endpoint of billing history, lists all payments and informations about them.</remarks>
        /// <response code="200"></response>
        [HttpGet]
        [Route("/laravel/api/certification/billingHistory")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("BillingHistory")]
        public virtual IActionResult BillingHistory()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// CDP Info
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200"></response>
        [HttpPost]
        [Route("/laravel/api/cpdinfo/show")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CDPInfo")]
        public virtual IActionResult CDPInfo([FromBody]Body1 body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Certification Education Step 3
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200"></response>
        [HttpPost]
        [Route("/laravel/api/certification/certification_education")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CertificationEducationStep3")]
        public virtual IActionResult CertificationEducationStep3([FromBody]string body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// DECLARATION - SHOW
        /// </summary>
        /// <remarks>This endpoint lists all types of declaration/agreements with its status.</remarks>
        /// <response code="200"></response>
        [HttpGet]
        [Route("/laravel/api/declaration/show")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("DECLARATIONSHOW")]
        public virtual IActionResult DECLARATIONSHOW()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Certificates Levels
        /// </summary>
        /// <remarks>Returns filtered certifications with its requirements based on certification level id and certification scheme id.</remarks>
        /// <param name="id"></param>
        /// <param name="cid"></param>
        /// <response code="200"></response>
        [HttpGet]
        [Route("/laravel/api/certification/certificatesLevels/{id}/{cid}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetCertificatesLevels")]
        public virtual IActionResult GetCertificatesLevels([FromRoute][Required]int? id, [FromRoute][Required]int? cid)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Education Levels
        /// </summary>
        /// <remarks>Gets all levels of eduction.</remarks>
        /// <response code="200"></response>
        [HttpGet]
        [Route("/laravel/api/certification/educationLevels")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetEducationLevels")]
        public virtual IActionResult GetEducationLevels()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// SUBMIT AMF
        /// </summary>
        /// <response code="200"></response>
        [HttpPost]
        [Route("/laravel/api/amf/create")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("SUBMITAMF")]
        public virtual IActionResult SUBMITAMF()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// SUBMIT CPD
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200"></response>
        [HttpPost]
        [Route("/laravel/api/cpdinfo/store")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("SUBMITCPD")]
        public virtual IActionResult SUBMITCPD([FromBody]string body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Show Certifications
        /// </summary>
        /// <remarks>Returns two arrays of current user cerfications that he applied for, divided based on incompleted and completed certifications.</remarks>
        /// <response code="200"></response>
        [HttpGet]
        [Route("/laravel/api/certification/show")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ShowCertifications")]
        public virtual IActionResult ShowCertifications()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Step 4
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200"></response>
        [HttpPost]
        [Route("/laravel/api/certification/professional_references")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("Step4")]
        public virtual IActionResult Step4([FromBody]string body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Step 6
        /// </summary>
        /// <remarks>This endpoint return all information about the certeficate application.</remarks>
        /// <param name="id"></param>
        /// <response code="200"></response>
        [HttpGet]
        [Route("/laravel/api/certification/getAllinfo/{id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("Step6")]
        public virtual IActionResult Step6([FromRoute][Required]int? id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// VIEW SUBMIT AMF
        /// </summary>
        /// <response code="200"></response>
        [HttpPost]
        [Route("/laravel/api/amf/show")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("VIEWSUBMITAMF")]
        public virtual IActionResult VIEWSUBMITAMF()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }
    }
}
