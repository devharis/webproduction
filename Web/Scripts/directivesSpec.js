/// <reference path="directives.ts" />
'use strict';
describe('Directives', function () {
    beforeEach(module('app.directives'));
    describe('app-version', function () {
        it('should print current version', function () {
            module(function ($provide) {
                $provide.value('version', 'TEST_VER');
            });
            inject(function ($compile, $rootScope) {
                var element = $compile('<span app-version></span>')($rootScope);
                expect(element.text()).toEqual('TEST_VER');
            });
        });
    });
});
//# sourceMappingURL=directivesSpec.js.map