/**
 * @license Copyright (c) 2003-2013, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see LICENSE.html or http://ckeditor.com/license
 */

CKEDITOR.editorConfig = function( config ) {
	// Define changes to default configuration here.
	// For the complete reference:
	// http://docs.ckeditor.com/#!/api/CKEDITOR.config

	// The toolbar groups arrangement, optimized for a single toolbar row.
    config.toolbarGroups = [
        { name: 'styles' },
		{ name: 'basicstyles', groups: [ 'basicstyles', 'cleanup','colors' ] },
		{ name: 'paragraph',   groups: [ 'list', 'indent', 'blocks', 'align' ] }
	];

	// The default plugins included in the basic setup define some buttons that
	// we don't want too have in a basic editor. We remove them here.
	config.removeButtons = 'Subscript,Superscript';
};
