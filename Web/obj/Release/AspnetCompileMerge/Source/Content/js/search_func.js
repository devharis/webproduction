$(document).ready(function(){$("#autocomplete-ajax").focus(function(){$("div.adv_search").fadeIn("medium");$(document).bind("focusin.adv_search click.adv_search",function(e){if($(e.target).closest(".adv_search, #autocomplete-ajax").length)return;$(document).unbind(".adv_search");$("div.adv_search").fadeOut("fast")})});$("div.adv_search").hide()})