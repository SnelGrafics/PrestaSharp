﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrestaSharp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PrestashopConnection : DbContext
    {
        public PrestashopConnection()
            : base("name=PrestashopConnection")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ps_access> ps_access { get; set; }
        public DbSet<ps_accessory> ps_accessory { get; set; }
        public DbSet<ps_address> ps_address { get; set; }
        public DbSet<ps_address_format> ps_address_format { get; set; }
        public DbSet<ps_advice> ps_advice { get; set; }
        public DbSet<ps_advice_lang> ps_advice_lang { get; set; }
        public DbSet<ps_alias> ps_alias { get; set; }
        public DbSet<ps_attachment> ps_attachment { get; set; }
        public DbSet<ps_attachment_lang> ps_attachment_lang { get; set; }
        public DbSet<ps_attribute> ps_attribute { get; set; }
        public DbSet<ps_attribute_group> ps_attribute_group { get; set; }
        public DbSet<ps_attribute_group_lang> ps_attribute_group_lang { get; set; }
        public DbSet<ps_attribute_group_shop> ps_attribute_group_shop { get; set; }
        public DbSet<ps_attribute_impact> ps_attribute_impact { get; set; }
        public DbSet<ps_attribute_lang> ps_attribute_lang { get; set; }
        public DbSet<ps_attribute_shop> ps_attribute_shop { get; set; }
        public DbSet<ps_badge> ps_badge { get; set; }
        public DbSet<ps_badge_lang> ps_badge_lang { get; set; }
        public DbSet<ps_carrier> ps_carrier { get; set; }
        public DbSet<ps_carrier_group> ps_carrier_group { get; set; }
        public DbSet<ps_carrier_lang> ps_carrier_lang { get; set; }
        public DbSet<ps_carrier_shop> ps_carrier_shop { get; set; }
        public DbSet<ps_carrier_tax_rules_group_shop> ps_carrier_tax_rules_group_shop { get; set; }
        public DbSet<ps_carrier_zone> ps_carrier_zone { get; set; }
        public DbSet<ps_cart> ps_cart { get; set; }
        public DbSet<ps_cart_cart_rule> ps_cart_cart_rule { get; set; }
        public DbSet<ps_cart_product> ps_cart_product { get; set; }
        public DbSet<ps_cart_rule> ps_cart_rule { get; set; }
        public DbSet<ps_cart_rule_carrier> ps_cart_rule_carrier { get; set; }
        public DbSet<ps_cart_rule_combination> ps_cart_rule_combination { get; set; }
        public DbSet<ps_cart_rule_country> ps_cart_rule_country { get; set; }
        public DbSet<ps_cart_rule_group> ps_cart_rule_group { get; set; }
        public DbSet<ps_cart_rule_lang> ps_cart_rule_lang { get; set; }
        public DbSet<ps_cart_rule_product_rule> ps_cart_rule_product_rule { get; set; }
        public DbSet<ps_cart_rule_product_rule_group> ps_cart_rule_product_rule_group { get; set; }
        public DbSet<ps_cart_rule_product_rule_value> ps_cart_rule_product_rule_value { get; set; }
        public DbSet<ps_cart_rule_shop> ps_cart_rule_shop { get; set; }
        public DbSet<ps_category> ps_category { get; set; }
        public DbSet<ps_category_group> ps_category_group { get; set; }
        public DbSet<ps_category_lang> ps_category_lang { get; set; }
        public DbSet<ps_category_product> ps_category_product { get; set; }
        public DbSet<ps_category_shop> ps_category_shop { get; set; }
        public DbSet<ps_cms> ps_cms { get; set; }
        public DbSet<ps_cms_block> ps_cms_block { get; set; }
        public DbSet<ps_cms_block_lang> ps_cms_block_lang { get; set; }
        public DbSet<ps_cms_block_page> ps_cms_block_page { get; set; }
        public DbSet<ps_cms_block_shop> ps_cms_block_shop { get; set; }
        public DbSet<ps_cms_category> ps_cms_category { get; set; }
        public DbSet<ps_cms_category_lang> ps_cms_category_lang { get; set; }
        public DbSet<ps_cms_lang> ps_cms_lang { get; set; }
        public DbSet<ps_cms_shop> ps_cms_shop { get; set; }
        public DbSet<ps_compare> ps_compare { get; set; }
        public DbSet<ps_compare_product> ps_compare_product { get; set; }
        public DbSet<ps_condition> ps_condition { get; set; }
        public DbSet<ps_condition_advice> ps_condition_advice { get; set; }
        public DbSet<ps_condition_badge> ps_condition_badge { get; set; }
        public DbSet<ps_configuration> ps_configuration { get; set; }
        public DbSet<ps_configuration_lang> ps_configuration_lang { get; set; }
        public DbSet<ps_connections> ps_connections { get; set; }
        public DbSet<ps_connections_page> ps_connections_page { get; set; }
        public DbSet<ps_connections_source> ps_connections_source { get; set; }
        public DbSet<ps_contact> ps_contact { get; set; }
        public DbSet<ps_contact_lang> ps_contact_lang { get; set; }
        public DbSet<ps_contact_shop> ps_contact_shop { get; set; }
        public DbSet<ps_country> ps_country { get; set; }
        public DbSet<ps_country_lang> ps_country_lang { get; set; }
        public DbSet<ps_country_shop> ps_country_shop { get; set; }
        public DbSet<ps_currency> ps_currency { get; set; }
        public DbSet<ps_currency_shop> ps_currency_shop { get; set; }
        public DbSet<ps_customer> ps_customer { get; set; }
        public DbSet<ps_customer_group> ps_customer_group { get; set; }
        public DbSet<ps_customer_message> ps_customer_message { get; set; }
        public DbSet<ps_customer_message_sync_imap> ps_customer_message_sync_imap { get; set; }
        public DbSet<ps_customer_thread> ps_customer_thread { get; set; }
        public DbSet<ps_customization> ps_customization { get; set; }
        public DbSet<ps_customization_field> ps_customization_field { get; set; }
        public DbSet<ps_customization_field_lang> ps_customization_field_lang { get; set; }
        public DbSet<ps_customized_data> ps_customized_data { get; set; }
        public DbSet<ps_date_range> ps_date_range { get; set; }
        public DbSet<ps_delivery> ps_delivery { get; set; }
        public DbSet<ps_employee> ps_employee { get; set; }
        public DbSet<ps_employee_shop> ps_employee_shop { get; set; }
        public DbSet<ps_favorite_product> ps_favorite_product { get; set; }
        public DbSet<ps_feature> ps_feature { get; set; }
        public DbSet<ps_feature_lang> ps_feature_lang { get; set; }
        public DbSet<ps_feature_product> ps_feature_product { get; set; }
        public DbSet<ps_feature_shop> ps_feature_shop { get; set; }
        public DbSet<ps_feature_value> ps_feature_value { get; set; }
        public DbSet<ps_feature_value_lang> ps_feature_value_lang { get; set; }
        public DbSet<ps_gender> ps_gender { get; set; }
        public DbSet<ps_gender_lang> ps_gender_lang { get; set; }
        public DbSet<ps_group> ps_group { get; set; }
        public DbSet<ps_group_lang> ps_group_lang { get; set; }
        public DbSet<ps_group_reduction> ps_group_reduction { get; set; }
        public DbSet<ps_group_shop> ps_group_shop { get; set; }
        public DbSet<ps_guest> ps_guest { get; set; }
        public DbSet<ps_help_access> ps_help_access { get; set; }
        public DbSet<ps_homeslider> ps_homeslider { get; set; }
        public DbSet<ps_homeslider_slides> ps_homeslider_slides { get; set; }
        public DbSet<ps_homeslider_slides_lang> ps_homeslider_slides_lang { get; set; }
        public DbSet<ps_hook> ps_hook { get; set; }
        public DbSet<ps_hook_alias> ps_hook_alias { get; set; }
        public DbSet<ps_hook_module> ps_hook_module { get; set; }
        public DbSet<ps_hook_module_exceptions> ps_hook_module_exceptions { get; set; }
        public DbSet<ps_image> ps_image { get; set; }
        public DbSet<ps_image_lang> ps_image_lang { get; set; }
        public DbSet<ps_image_shop> ps_image_shop { get; set; }
        public DbSet<ps_image_type> ps_image_type { get; set; }
        public DbSet<ps_import_match> ps_import_match { get; set; }
        public DbSet<ps_lang> ps_lang { get; set; }
        public DbSet<ps_lang_shop> ps_lang_shop { get; set; }
        public DbSet<ps_linksmenutop> ps_linksmenutop { get; set; }
        public DbSet<ps_linksmenutop_lang> ps_linksmenutop_lang { get; set; }
        public DbSet<ps_log> ps_log { get; set; }
        public DbSet<ps_manufacturer> ps_manufacturer { get; set; }
        public DbSet<ps_manufacturer_lang> ps_manufacturer_lang { get; set; }
        public DbSet<ps_manufacturer_shop> ps_manufacturer_shop { get; set; }
        public DbSet<ps_memcached_servers> ps_memcached_servers { get; set; }
        public DbSet<ps_message> ps_message { get; set; }
        public DbSet<ps_message_readed> ps_message_readed { get; set; }
        public DbSet<ps_meta> ps_meta { get; set; }
        public DbSet<ps_meta_lang> ps_meta_lang { get; set; }
        public DbSet<ps_module> ps_module { get; set; }
        public DbSet<ps_module_access> ps_module_access { get; set; }
        public DbSet<ps_module_country> ps_module_country { get; set; }
        public DbSet<ps_module_currency> ps_module_currency { get; set; }
        public DbSet<ps_module_group> ps_module_group { get; set; }
        public DbSet<ps_module_preference> ps_module_preference { get; set; }
        public DbSet<ps_module_shop> ps_module_shop { get; set; }
        public DbSet<ps_newsletter> ps_newsletter { get; set; }
        public DbSet<ps_operating_system> ps_operating_system { get; set; }
        public DbSet<ps_order_carrier> ps_order_carrier { get; set; }
        public DbSet<ps_order_cart_rule> ps_order_cart_rule { get; set; }
        public DbSet<ps_order_detail> ps_order_detail { get; set; }
        public DbSet<ps_order_detail_tax> ps_order_detail_tax { get; set; }
        public DbSet<ps_order_history> ps_order_history { get; set; }
        public DbSet<ps_order_invoice> ps_order_invoice { get; set; }
        public DbSet<ps_order_invoice_payment> ps_order_invoice_payment { get; set; }
        public DbSet<ps_order_invoice_tax> ps_order_invoice_tax { get; set; }
        public DbSet<ps_order_message> ps_order_message { get; set; }
        public DbSet<ps_order_message_lang> ps_order_message_lang { get; set; }
        public DbSet<ps_order_payment> ps_order_payment { get; set; }
        public DbSet<ps_order_return> ps_order_return { get; set; }
        public DbSet<ps_order_return_detail> ps_order_return_detail { get; set; }
        public DbSet<ps_order_return_state> ps_order_return_state { get; set; }
        public DbSet<ps_order_return_state_lang> ps_order_return_state_lang { get; set; }
        public DbSet<ps_order_slip> ps_order_slip { get; set; }
        public DbSet<ps_order_slip_detail> ps_order_slip_detail { get; set; }
        public DbSet<ps_order_state> ps_order_state { get; set; }
        public DbSet<ps_order_state_lang> ps_order_state_lang { get; set; }
        public DbSet<ps_orders> ps_orders { get; set; }
        public DbSet<ps_pack> ps_pack { get; set; }
        public DbSet<ps_page> ps_page { get; set; }
        public DbSet<ps_page_type> ps_page_type { get; set; }
        public DbSet<ps_page_viewed> ps_page_viewed { get; set; }
        public DbSet<ps_pagenotfound> ps_pagenotfound { get; set; }
        public DbSet<ps_product> ps_product { get; set; }
        public DbSet<ps_product_attachment> ps_product_attachment { get; set; }
        public DbSet<ps_product_attribute> ps_product_attribute { get; set; }
        public DbSet<ps_product_attribute_combination> ps_product_attribute_combination { get; set; }
        public DbSet<ps_product_attribute_image> ps_product_attribute_image { get; set; }
        public DbSet<ps_product_attribute_shop> ps_product_attribute_shop { get; set; }
        public DbSet<ps_product_carrier> ps_product_carrier { get; set; }
        public DbSet<ps_product_country_tax> ps_product_country_tax { get; set; }
        public DbSet<ps_product_download> ps_product_download { get; set; }
        public DbSet<ps_product_group_reduction_cache> ps_product_group_reduction_cache { get; set; }
        public DbSet<ps_product_lang> ps_product_lang { get; set; }
        public DbSet<ps_product_sale> ps_product_sale { get; set; }
        public DbSet<ps_product_shop> ps_product_shop { get; set; }
        public DbSet<ps_product_supplier> ps_product_supplier { get; set; }
        public DbSet<ps_product_tag> ps_product_tag { get; set; }
        public DbSet<ps_profile> ps_profile { get; set; }
        public DbSet<ps_profile_lang> ps_profile_lang { get; set; }
        public DbSet<ps_quick_access> ps_quick_access { get; set; }
        public DbSet<ps_quick_access_lang> ps_quick_access_lang { get; set; }
        public DbSet<ps_range_price> ps_range_price { get; set; }
        public DbSet<ps_range_weight> ps_range_weight { get; set; }
        public DbSet<ps_referrer> ps_referrer { get; set; }
        public DbSet<ps_referrer_cache> ps_referrer_cache { get; set; }
        public DbSet<ps_referrer_shop> ps_referrer_shop { get; set; }
        public DbSet<ps_reinsurance> ps_reinsurance { get; set; }
        public DbSet<ps_reinsurance_lang> ps_reinsurance_lang { get; set; }
        public DbSet<ps_request_sql> ps_request_sql { get; set; }
        public DbSet<ps_required_field> ps_required_field { get; set; }
        public DbSet<ps_risk> ps_risk { get; set; }
        public DbSet<ps_risk_lang> ps_risk_lang { get; set; }
        public DbSet<ps_scene> ps_scene { get; set; }
        public DbSet<ps_scene_category> ps_scene_category { get; set; }
        public DbSet<ps_scene_lang> ps_scene_lang { get; set; }
        public DbSet<ps_scene_products> ps_scene_products { get; set; }
        public DbSet<ps_scene_shop> ps_scene_shop { get; set; }
        public DbSet<ps_search_engine> ps_search_engine { get; set; }
        public DbSet<ps_search_index> ps_search_index { get; set; }
        public DbSet<ps_search_word> ps_search_word { get; set; }
        public DbSet<ps_sekeyword> ps_sekeyword { get; set; }
        public DbSet<ps_shop> ps_shop { get; set; }
        public DbSet<ps_shop_group> ps_shop_group { get; set; }
        public DbSet<ps_shop_url> ps_shop_url { get; set; }
        public DbSet<ps_specific_price> ps_specific_price { get; set; }
        public DbSet<ps_specific_price_priority> ps_specific_price_priority { get; set; }
        public DbSet<ps_specific_price_rule> ps_specific_price_rule { get; set; }
        public DbSet<ps_specific_price_rule_condition> ps_specific_price_rule_condition { get; set; }
        public DbSet<ps_specific_price_rule_condition_group> ps_specific_price_rule_condition_group { get; set; }
        public DbSet<ps_state> ps_state { get; set; }
        public DbSet<ps_statssearch> ps_statssearch { get; set; }
        public DbSet<ps_stock> ps_stock { get; set; }
        public DbSet<ps_stock_available> ps_stock_available { get; set; }
        public DbSet<ps_stock_mvt> ps_stock_mvt { get; set; }
        public DbSet<ps_stock_mvt_reason> ps_stock_mvt_reason { get; set; }
        public DbSet<ps_stock_mvt_reason_lang> ps_stock_mvt_reason_lang { get; set; }
        public DbSet<ps_store> ps_store { get; set; }
        public DbSet<ps_store_shop> ps_store_shop { get; set; }
        public DbSet<ps_supplier> ps_supplier { get; set; }
        public DbSet<ps_supplier_lang> ps_supplier_lang { get; set; }
        public DbSet<ps_supplier_shop> ps_supplier_shop { get; set; }
        public DbSet<ps_supply_order> ps_supply_order { get; set; }
        public DbSet<ps_supply_order_detail> ps_supply_order_detail { get; set; }
        public DbSet<ps_supply_order_history> ps_supply_order_history { get; set; }
        public DbSet<ps_supply_order_receipt_history> ps_supply_order_receipt_history { get; set; }
        public DbSet<ps_supply_order_state> ps_supply_order_state { get; set; }
        public DbSet<ps_supply_order_state_lang> ps_supply_order_state_lang { get; set; }
        public DbSet<ps_tab> ps_tab { get; set; }
        public DbSet<ps_tab_lang> ps_tab_lang { get; set; }
        public DbSet<ps_tab_module_preference> ps_tab_module_preference { get; set; }
        public DbSet<ps_tag> ps_tag { get; set; }
        public DbSet<ps_tax> ps_tax { get; set; }
        public DbSet<ps_tax_lang> ps_tax_lang { get; set; }
        public DbSet<ps_tax_rule> ps_tax_rule { get; set; }
        public DbSet<ps_tax_rules_group> ps_tax_rules_group { get; set; }
        public DbSet<ps_tax_rules_group_shop> ps_tax_rules_group_shop { get; set; }
        public DbSet<ps_theme> ps_theme { get; set; }
        public DbSet<ps_theme_specific> ps_theme_specific { get; set; }
        public DbSet<ps_timezone> ps_timezone { get; set; }
        public DbSet<ps_warehouse> ps_warehouse { get; set; }
        public DbSet<ps_warehouse_carrier> ps_warehouse_carrier { get; set; }
        public DbSet<ps_warehouse_product_location> ps_warehouse_product_location { get; set; }
        public DbSet<ps_warehouse_shop> ps_warehouse_shop { get; set; }
        public DbSet<ps_web_browser> ps_web_browser { get; set; }
        public DbSet<ps_webservice_account> ps_webservice_account { get; set; }
        public DbSet<ps_webservice_account_shop> ps_webservice_account_shop { get; set; }
        public DbSet<ps_webservice_permission> ps_webservice_permission { get; set; }
        public DbSet<ps_zone> ps_zone { get; set; }
        public DbSet<ps_zone_shop> ps_zone_shop { get; set; }
    }
}
