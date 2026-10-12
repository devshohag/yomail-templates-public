<?php
/**
 * Plugin Name: YoMail Starter
 * Description: A minimal starter plugin for a YoMail-hosted WordPress site.
 * Version: 1.0.0
 */

add_shortcode('yomail_greeting', static function (): string {
    return '<p>Welcome to your YoMail WordPress site.</p>';
});
