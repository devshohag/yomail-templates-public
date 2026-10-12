<?php

use Illuminate\Support\Facades\Artisan;

Artisan::command('starter:hello', function (): void {
    $this->comment('Laravel starter is ready.');
})->purpose('Check that the Laravel starter is installed.');
