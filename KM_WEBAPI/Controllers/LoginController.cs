using KM_WEBAPI.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace KM_WEBAPI.Controllers
{
    public class LoginController : ApiController
    {
       public class loginBody{


            /// <summary>
            /// 登陆账号
            /// </summary>
            [HttpBindRequired]
            public string userNum { get; set; }


            /// <summary>
            /// 登陆密码
            /// </summary>
            [HttpBindRequired]
            public    string userPass { get; set; }
    }



        /// <summary>
        /// 登陆效验
        /// </summary>
        /// <param name="data">登陆实体</param>
        /// <returns></returns>
        [HttpPost]
        public LoginResoult  CheckUser([FromBody]   loginBody  data)
        {
            if (!string.IsNullOrEmpty (data.userNum) && !string.IsNullOrEmpty(data.userPass))
            {
                return new LoginResoult() {Status =1,Message="OK" };
            }
            else
            {
                return new LoginResoult() { Status =0, Message = "ERROR" };
            }
        }



        /// <summary>
        /// 测试JObject
        /// </summary>
        /// <param name="data"> {"name":"a simple string"}    </param>
        /// <returns></returns>
        [HttpPost]
        public string PostValue([FromBody]   dynamic data)
        {
            return data["name"].ToObject<string>();
        }


        public class Demo
        {
            public string pram1 { get; set; }
                
            public string pram2 { get; set; }
        }

        public string Tset([FromBody ] Demo data )
        {
            return "46578798";
        }


    }
}
