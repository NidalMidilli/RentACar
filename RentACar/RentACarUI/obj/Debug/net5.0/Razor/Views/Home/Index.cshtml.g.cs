#pragma checksum "C:\Users\nidal\source\repos\RentACar\RentACarUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cdbd8fb84e2e35ab294c28bab91c291f1b5d74c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\nidal\source\repos\RentACar\RentACarUI\Views\_ViewImports.cshtml"
using RentACarUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nidal\source\repos\RentACar\RentACarUI\Views\_ViewImports.cshtml"
using RentACarUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\nidal\source\repos\RentACar\RentACarUI\Views\Home\Index.cshtml"
using EntityLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cdbd8fb84e2e35ab294c28bab91c291f1b5d74c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3924a4a624913d08a7c8f6d2bdc11d484e3c8ec", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Car>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("trip-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/feature_01.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/car_6.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/person_1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/person_2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/person_3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""hero"" style=""background-image: url('images/hero_1_a.jpg');"">

    <div class=""container"">
        <div class=""row align-items-center justify-content-center"">
            <div class=""col-lg-10"">

                <div class=""row mb-5"">
                    <div class=""col-lg-7 intro"">
                        <h1><strong>Rent a car</strong> is within your finger tips.</h1>
                    </div>
                </div>

                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cdbd8fb84e2e35ab294c28bab91c291f1b5d74c7693", async() => {
                WriteLiteral("\r\n\r\n                    <div class=\"row align-items-center\">\r\n\r\n                        <div class=\"mb-3 mb-md-0 col-md-3\">\r\n                            <select");
                BeginWriteAttribute("name", " name=\"", 687, "\"", 694, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 695, "\"", 700, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"custom-select form-control\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cdbd8fb84e2e35ab294c28bab91c291f1b5d74c8456", async() => {
                    WriteLiteral("Select Type");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cdbd8fb84e2e35ab294c28bab91c291f1b5d74c9716", async() => {
                    WriteLiteral("Ferrari");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cdbd8fb84e2e35ab294c28bab91c291f1b5d74c10972", async() => {
                    WriteLiteral("Toyota");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cdbd8fb84e2e35ab294c28bab91c291f1b5d74c12228", async() => {
                    WriteLiteral("Ford");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cdbd8fb84e2e35ab294c28bab91c291f1b5d74c13482", async() => {
                    WriteLiteral("Lamborghini");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                        <div class=""mb-3 mb-md-0 col-md-3"">
                            <div class=""form-control-wrap"">
                                <input type=""text"" id=""cf-3"" placeholder=""Pick up"" class=""form-control datepicker px-3"">
                                <span class=""icon icon-date_range""></span>

                            </div>
                        </div>
                        <div class=""mb-3 mb-md-0 col-md-3"">
                            <div class=""form-control-wrap"">
                                <input type=""text"" id=""cf-4"" placeholder=""Drop off"" class=""form-control datepicker px-3"">
                                <span class=""icon icon-date_range""></span>
                            </div>
                        </div>
                        <div class=""mb-3 mb-md-0 col-md-3"">
                            <input type=""submit"" value=""Search Now"" class=""btn btn-primary btn-block py-3"">
  ");
                WriteLiteral("                      </div>\r\n                    </div>\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            </div>
        </div>
    </div>
</div>



<div class=""site-section"">
    <div class=""container"">
        <h2 class=""section-heading""><strong>How it works?</strong></h2>
        <p class=""mb-5"">Easy steps to get you started</p>

        <div class=""row mb-5"">
            <div class=""col-lg-4 mb-4 mb-lg-0"">
                <div class=""step"">
                    <span>1</span>
                    <div class=""step-inner"">
                        <span class=""number text-primary"">01.</span>
                        <h3>Select a car</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Vero, laboriosam!</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 mb-4 mb-lg-0"">
                <div class=""step"">
                    <span>2</span>
                    <div class=""step-inner"">
                        <span class=""number text-primary"">02.</span>
                        <h3>Fill u");
            WriteLiteral(@"p form</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Vero, laboriosam!</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 mb-4 mb-lg-0"">
                <div class=""step"">
                    <span>3</span>
                    <div class=""step-inner"">
                        <span class=""number text-primary"">03.</span>
                        <h3>Payment</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Vero, laboriosam!</p>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4 mx-auto"">
                <a href=""#"" class=""d-flex align-items-center play-now mx-auto"">
                    <span class=""icon"">
                        <span class=""icon-play""></span>
                    </span>
                    <span class=""caption"">Video how it works</span>
        ");
            WriteLiteral(@"        </a>
            </div>
        </div>
    </div>
</div>

<div class=""site-section"">
    <div class=""container"">
        <div class=""row align-items-center"">
            <div class=""col-lg-7 text-center order-lg-2"">
                <div class=""img-wrap-1 mb-5"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7cdbd8fb84e2e35ab294c28bab91c291f1b5d74c19409", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-lg-4 ml-auto order-lg-1"">
                <h3 class=""mb-4 section-heading""><strong>You can easily avail our promo for renting a car.</strong></h3>
                <p class=""mb-5"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Repudiandae, explicabo iste a labore id est quas, doloremque veritatis! Provident odit pariatur dolorem quisquam, voluptatibus voluptates optio accusamus, vel quasi quidem!</p>

                <p><a href=""#"" class=""btn btn-primary"">Meet them now</a></p>
            </div>
        </div>
    </div>
</div>



<div class=""site-section bg-light"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-7"">
                <h2 class=""section-heading""><strong>Car Listings</strong></h2>
                <p class=""mb-5"">Lorem ipsum dolor sit amet, consectetur adipisicing elit.</p>
            </div>
        </div>


        <div class=""row"">
");
#nullable restore
#line 137 "C:\Users\nidal\source\repos\RentACar\RentACarUI\Views\Home\Index.cshtml"
             foreach (var item in Model)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-4 mb-4\">\r\n\r\n                    <div class=\"listing d-block  align-items-stretch\">\r\n                        <div class=\"listing-img h-100 mr-4\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7cdbd8fb84e2e35ab294c28bab91c291f1b5d74c22104", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"listing-contents h-100\">\r\n                            <h3>");
#nullable restore
#line 146 "C:\Users\nidal\source\repos\RentACar\RentACarUI\Views\Home\Index.cshtml"
                           Write(item.carName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <div class=\"rent-price\">\r\n                                <strong>");
#nullable restore
#line 148 "C:\Users\nidal\source\repos\RentACar\RentACarUI\Views\Home\Index.cshtml"
                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong><span class=""mx-1"">/</span>day
                            </div>
                            <div class=""d-block d-md-flex mb-3 border-bottom pb-3"">
                                <div class=""listing-feature pr-4"">
                                    <span class=""caption"">Luggage:</span>
                                    <span class=""number"">");
#nullable restore
#line 153 "C:\Users\nidal\source\repos\RentACar\RentACarUI\Views\Home\Index.cshtml"
                                                    Write(item.Luggage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <div class=\"listing-feature pr-4\">\r\n                                    <span class=\"caption\">Doors:</span>\r\n                                    <span class=\"number\">");
#nullable restore
#line 157 "C:\Users\nidal\source\repos\RentACar\RentACarUI\Views\Home\Index.cshtml"
                                                    Write(item.Doors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <div class=\"listing-feature pr-4\">\r\n                                    <span class=\"caption\">Passenger:</span>\r\n                                    <span class=\"number\">");
#nullable restore
#line 161 "C:\Users\nidal\source\repos\RentACar\RentACarUI\Views\Home\Index.cshtml"
                                                    Write(item.Passenger);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 168 "C:\Users\nidal\source\repos\RentACar\RentACarUI\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          

          




        </div>
    </div>
</div>

<div class=""site-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-7"">
                <h2 class=""section-heading""><strong>Features</strong></h2>
                <p class=""mb-5"">Lorem ipsum dolor sit amet, consectetur adipisicing elit.</p>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-lg-4 mb-5"">
                <div class=""service-1 dark"">
                    <span class=""service-1-icon"">
                        <span class=""icon-home""></span>
                    </span>
                    <div class=""service-1-contents"">
                        <h3>Lorem ipsum dolor</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati, laboriosam.</p>
                        <p class=""mb-0""><a href=""#"">Learn more</a></p>
                    </div>
                </div>
            </div>
         ");
            WriteLiteral(@"   <div class=""col-lg-4 mb-5"">
                <div class=""service-1 dark"">
                    <span class=""service-1-icon"">
                        <span class=""icon-gear""></span>
                    </span>
                    <div class=""service-1-contents"">
                        <h3>Lorem ipsum dolor</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati, laboriosam.</p>
                        <p class=""mb-0""><a href=""#"">Learn more</a></p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 mb-5"">
                <div class=""service-1 dark"">
                    <span class=""service-1-icon"">
                        <span class=""icon-watch_later""></span>
                    </span>
                    <div class=""service-1-contents"">
                        <h3>Lorem ipsum dolor</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati, laboriosam.</");
            WriteLiteral(@"p>
                        <p class=""mb-0""><a href=""#"">Learn more</a></p>
                    </div>
                </div>
            </div>

            <div class=""col-lg-4 mb-5"">
                <div class=""service-1 dark"">
                    <span class=""service-1-icon"">
                        <span class=""icon-verified_user""></span>
                    </span>
                    <div class=""service-1-contents"">
                        <h3>Lorem ipsum dolor</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati, laboriosam.</p>
                        <p class=""mb-0""><a href=""#"">Learn more</a></p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 mb-5"">
                <div class=""service-1 dark"">
                    <span class=""service-1-icon"">
                        <span class=""icon-video_library""></span>
                    </span>
                    <div class=""service-1-con");
            WriteLiteral(@"tents"">
                        <h3>Lorem ipsum dolor</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati, laboriosam.</p>
                        <p class=""mb-0""><a href=""#"">Learn more</a></p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 mb-5"">
                <div class=""service-1 dark"">
                    <span class=""service-1-icon"">
                        <span class=""icon-vpn_key""></span>
                    </span>
                    <div class=""service-1-contents"">
                        <h3>Lorem ipsum dolor</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati, laboriosam.</p>
                        <p class=""mb-0""><a href=""#"">Learn more</a></p>
                    </div>
                </div>
            </div>

        </div>
    </div>
</div>

<div class=""site-section bg-light"">
    <div class=""container"">
        <d");
            WriteLiteral(@"iv class=""row"">
            <div class=""col-lg-7"">
                <h2 class=""section-heading""><strong>Testimonials</strong></h2>
                <p class=""mb-5"">Lorem ipsum dolor sit amet, consectetur adipisicing elit.</p>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4 mb-4 mb-lg-0"">
                <div class=""testimonial-2"">
                    <blockquote class=""mb-4"">
                        <p>""Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatem, deserunt eveniet veniam. Ipsam, nam, voluptatum""</p>
                    </blockquote>
                    <div class=""d-flex v-card align-items-center"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7cdbd8fb84e2e35ab294c28bab91c291f1b5d74c31134", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""author-name"">
                            <span class=""d-block"">Mike Fisher</span>
                            <span>Owner, Ford</span>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 mb-4 mb-lg-0"">
                <div class=""testimonial-2"">
                    <blockquote class=""mb-4"">
                        <p>""Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatem, deserunt eveniet veniam. Ipsam, nam, voluptatum""</p>
                    </blockquote>
                    <div class=""d-flex v-card align-items-center"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7cdbd8fb84e2e35ab294c28bab91c291f1b5d74c33044", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""author-name"">
                            <span class=""d-block"">Jean Stanley</span>
                            <span>Traveler</span>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 mb-4 mb-lg-0"">
                <div class=""testimonial-2"">
                    <blockquote class=""mb-4"">
                        <p>""Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatem, deserunt eveniet veniam. Ipsam, nam, voluptatum""</p>
                    </blockquote>
                    <div class=""d-flex v-card align-items-center"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7cdbd8fb84e2e35ab294c28bab91c291f1b5d74c34952", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""author-name"">
                            <span class=""d-block"">Katie Rose</span>
                            <span>Customer</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""site-section bg-primary py-5"">
    <div class=""container"">
        <div class=""row align-items-center"">
            <div class=""col-lg-7 mb-4 mb-md-0"">
                <h2 class=""mb-0 text-white"">What are you waiting for?</h2>
                <p class=""mb-0 opa-7"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati, laboriosam.</p>
            </div>
            <div class=""col-lg-5 text-md-right"">
                <a href=""#"" class=""btn btn-primary btn-white"">Rent a car now</a>
            </div>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Car>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591