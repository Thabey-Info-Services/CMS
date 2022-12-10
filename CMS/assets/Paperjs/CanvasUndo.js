﻿(function () {
    var l;

    function aa() {
        var a = ba,
            b = 0;
        return function () {
            return b < a.length ? {
                done: !1,
                value: a[b++]
            } : {
                done: !0
            }
        }
    }
    var ca = "function" == typeof Object.create ? Object.create : function (a) {
        function b() { }
        b.prototype = a;
        return new b
    },
        da;
    if ("function" == typeof Object.setPrototypeOf) da = Object.setPrototypeOf;
    else {
        var ea;
        a: {
            var fa = {
                Ca: !0
            },
                ha = {};
            try {
                ha.__proto__ = fa;
                ea = ha.Ca;
                break a
            } catch (a) { }
            ea = !1
        }
        da = ea ? function (a, b) {
            a.__proto__ = b;
            if (a.__proto__ !== b) throw new TypeError(a + " is not extensible");
            return a
        } : null
    }
    var ia = da;

    function ja(a, b) {
        a.prototype = ca(b.prototype);
        a.prototype.constructor = a;
        if (ia) ia(a, b);
        else
            for (var c in b)
                if ("prototype" != c)
                    if (Object.defineProperties) {
                        var d = Object.getOwnPropertyDescriptor(b, c);
                        d && Object.defineProperty(a, c, d)
                    } else a[c] = b[c];
        a.Va = b.prototype
    }
    var ka = "function" == typeof Object.defineProperties ? Object.defineProperty : function (a, b, c) {
        a != Array.prototype && a != Object.prototype && (a[b] = c.value)
    },
        la = "undefined" != typeof window && window === this ? this : "undefined" != typeof global && null != global ? global : this;

    function ma(a, b) {
        if (b) {
            var c = la;
            a = a.split(".");
            for (var d = 0; d < a.length - 1; d++) {
                var e = a[d];
                e in c || (c[e] = {});
                c = c[e]
            }
            a = a[a.length - 1];
            d = c[a];
            b = b(d);
            b != d && null != b && ka(c, a, {
                configurable: !0,
                writable: !0,
                value: b
            })
        }
    }
    ma("String.prototype.endsWith", function (a) {
        return a ? a : function (a, c) {
            if (null == this) throw new TypeError("The 'this' value for String.prototype.endsWith must not be null or undefined");
            if (a instanceof RegExp) throw new TypeError("First argument to String.prototype.endsWith must not be a regular expression");
            void 0 === c && (c = this.length);
            c = Math.max(0, Math.min(c | 0, this.length));
            for (var b = a.length; 0 < b && 0 < c;)
                if (this[--c] != a[--b]) return !1;
            return 0 >= b
        }
    });
    var na = "function" == typeof Object.assign ? Object.assign : function (a, b) {
        for (var c = 1; c < arguments.length; c++) {
            var d = arguments[c];
            if (d)
                for (var e in d) Object.prototype.hasOwnProperty.call(d, e) && (a[e] = d[e])
        }
        return a
    };
    ma("Object.assign", function (a) {
        return a || na
    });
    ma("Object.is", function (a) {
        return a ? a : function (a, c) {
            return a === c ? 0 !== a || 1 / a === 1 / c : a !== a && c !== c
        }
    });
    ma("Number.isNaN", function (a) {
        return a ? a : function (a) {
            return "number" === typeof a && isNaN(a)
        }
    });
    var q = this;

    function r(a) {
        return "string" == typeof a
    }

    function oa(a) {
        return "number" == typeof a
    }

    function pa() {
        if (null === qa) a: {
            var a = q.document;
            if ((a = a.querySelector && a.querySelector("script[nonce]")) && (a = a.nonce || a.getAttribute("nonce")) && ra.test(a)) {
                qa = a;
                break a
            }
            qa = ""
        }
        return qa
    }
    var ra = /^[\w+/_-]+[=]{0,2}$/,
        qa = null;

    function sa() { }

    function ta(a) {
        a.X = void 0;
        a.ja = function () {
            return a.X ? a.X : a.X = new a
        }
    }

    function ua(a) {
        var b = typeof a;
        if ("object" == b)
            if (a) {
                if (a instanceof Array) return "array";
                if (a instanceof Object) return b;
                var c = Object.prototype.toString.call(a);
                if ("[object Window]" == c) return "object";
                if ("[object Array]" == c || "number" == typeof a.length && "undefined" != typeof a.splice && "undefined" != typeof a.propertyIsEnumerable && !a.propertyIsEnumerable("splice")) return "array";
                if ("[object Function]" == c || "undefined" != typeof a.call && "undefined" != typeof a.propertyIsEnumerable && !a.propertyIsEnumerable("call")) return "function"
            } else return "null";
        else if ("function" == b && "undefined" == typeof a.call) return "object";
        return b
    }

    function va(a) {
        return null === a
    }

    function wa(a) {
        var b = typeof a;
        return "object" == b && null != a || "function" == b
    }

    function xa(a, b, c) {
        return a.call.apply(a.bind, arguments)
    }

    function ya(a, b, c) {
        if (!a) throw Error();
        if (2 < arguments.length) {
            var d = Array.prototype.slice.call(arguments, 2);
            return function () {
                var c = Array.prototype.slice.call(arguments);
                Array.prototype.unshift.apply(c, d);
                return a.apply(b, c)
            }
        }
        return function () {
            return a.apply(b, arguments)
        }
    }

    function za(a, b, c) {
        Function.prototype.bind && -1 != Function.prototype.bind.toString().indexOf("native code") ? za = xa : za = ya;
        return za.apply(null, arguments)
    }

    function Aa(a, b) {
        var c = Array.prototype.slice.call(arguments, 1);
        return function () {
            var b = c.slice();
            b.push.apply(b, arguments);
            return a.apply(this, b)
        }
    }

    function u(a, b) {
        function c() { }
        c.prototype = b.prototype;
        a.Va = b.prototype;
        a.prototype = new c;
        a.prototype.constructor = a;
        a.Xa = function (a, c, f) {
            for (var d = Array(arguments.length - 2), e = 2; e < arguments.length; e++) d[e - 2] = arguments[e];
            return b.prototype[c].apply(a, d)
        }
    };
    var Ba = (new Date).getTime();

    function Ca(a, b) {
        if (r(a)) return r(b) && 1 == b.length ? a.indexOf(b, 0) : -1;
        for (var c = 0; c < a.length; c++)
            if (c in a && a[c] === b) return c;
        return -1
    }

    function Da(a, b) {
        for (var c = a.length, d = r(a) ? a.split("") : a, e = 0; e < c; e++) e in d && b.call(void 0, d[e], e, a)
    }

    function Ea(a, b) {
        for (var c = a.length, d = Array(c), e = r(a) ? a.split("") : a, f = 0; f < c; f++) f in e && (d[f] = b.call(void 0, e[f], f, a));
        return d
    }

    function Fa(a, b) {
        a: {
            for (var c = a.length, d = r(a) ? a.split("") : a, e = 0; e < c; e++)
                if (e in d && b.call(void 0, d[e], e, a)) {
                    b = e;
                    break a
                }
            b = -1
        }
        return 0 > b ? null : r(a) ? a.charAt(b) : a[b]
    };

    function Ha(a) {
        return /^[\s\xa0]*([\s\S]*?)[\s\xa0]*$/.exec(a)[1]
    }
    var Ia = /&/g,
        Ja = /</g,
        Ka = />/g,
        La = /"/g,
        Ma = /'/g,
        Na = /\x00/g;

    function v(a, b) {
        return -1 != a.indexOf(b)
    };
    var Oa = {
        "\x00": "\\0",
        "\b": "\\b",
        "\f": "\\f",
        "\n": "\\n",
        "\r": "\\r",
        "\t": "\\t",
        "\x0B": "\\x0B",
        '"': '\\"',
        "\\": "\\\\",
        "<": "<"
    },
        Pa = {
            "'": "\\'"
        };

    function Qa(a) {
        return String(a).replace(/\-([a-z])/g, function (a, c) {
            return c.toUpperCase()
        })
    };
    var w;
    a: {
        var Ra = q.navigator;
        if (Ra) {
            var Sa = Ra.userAgent;
            if (Sa) {
                w = Sa;
                break a
            }
        }
        w = ""
    };

    function Ta(a, b) {
        for (var c in a)
            if (b.call(void 0, a[c], c, a)) return !0;
        return !1
    }

    function Ua(a) {
        var b = [],
            c = 0,
            d;
        for (d in a) b[c++] = a[d];
        return b
    }

    function Va(a) {
        var b = {},
            c;
        for (c in a) b[c] = a[c];
        return b
    };

    function Wa(a) {
        Wa[" "](a);
        return a
    }
    Wa[" "] = sa;

    function x() { }
    var Xa = "function" == typeof Uint8Array;

    function z(a, b, c, d) {
        a.a = null;
        b || (b = []);
        a.L = void 0;
        a.h = -1;
        a.b = b;
        a: {
            if (b = a.b.length) {
                --b;
                var e = a.b[b];
                if (null !== e && "object" == typeof e && "array" != ua(e) && !(Xa && e instanceof Uint8Array)) {
                    a.i = b - a.h;
                    a.g = e;
                    break a
                }
            }
            a.i = Number.MAX_VALUE
        }
        a.I = {};
        if (c)
            for (b = 0; b < c.length; b++) e = c[b], e < a.i ? (e += a.h, a.b[e] = a.b[e] || Ya) : (Za(a), a.g[e] = a.g[e] || Ya);
        if (d && d.length)
            for (b = 0; b < d.length; b++) $a(a, d[b])
    }
    var Ya = [];

    function Za(a) {
        var b = a.i + a.h;
        a.b[b] || (a.g = a.b[b] = {})
    }

    function A(a, b) {
        if (b < a.i) {
            b += a.h;
            var c = a.b[b];
            return c === Ya ? a.b[b] = [] : c
        }
        if (a.g) return c = a.g[b], c === Ya ? a.g[b] = [] : c
    }

    function ab(a, b, c) {
        a = A(a, b);
        return null == a ? c : a
    }

    function bb(a, b, c) {
        b < a.i ? a.b[b + a.h] = c : (Za(a), a.g[b] = c)
    }

    function $a(a, b) {
        for (var c, d, e = 0; e < b.length; e++) {
            var f = b[e],
                g = A(a, f);
            null != g && (c = f, d = g, bb(a, f, void 0))
        }
        return c ? (bb(a, c, d), c) : 0
    }

    function cb(a, b, c) {
        a.a || (a.a = {});
        if (!a.a[c]) {
            var d = A(a, c);
            d && (a.a[c] = new b(d))
        }
        return a.a[c]
    }

    function db(a, b, c) {
        a.a || (a.a = {});
        if (!a.a[c]) {
            for (var d = A(a, c), e = [], f = 0; f < d.length; f++) e[f] = new b(d[f]);
            a.a[c] = e
        }
        b = a.a[c];
        b == Ya && (b = a.a[c] = []);
        return b
    }

    function eb(a) {
        if (a.a)
            for (var b in a.a) {
                var c = a.a[b];
                if ("array" == ua(c))
                    for (var d = 0; d < c.length; d++) c[d] && eb(c[d]);
                else c && eb(c)
            }
        return a.b
    };

    function fb(a) {
        z(this, a, gb, null)
    }
    u(fb, x);

    function hb(a) {
        z(this, a, null, null)
    }
    u(hb, x);
    var gb = [2, 3];
    var ib = document,
        B = window;
    var jb = {
        "120x90": !0,
        "160x90": !0,
        "180x90": !0,
        "200x90": !0,
        "468x15": !0,
        "728x15": !0
    };

    function kb(a, b) {
        if (15 == b) {
            if (728 <= a) return 728;
            if (468 <= a) return 468
        } else if (90 == b) {
            if (200 <= a) return 200;
            if (180 <= a) return 180;
            if (160 <= a) return 160;
            if (120 <= a) return 120
        }
        return null
    };

    function lb() {
        return function () {
            return !va.apply(this, arguments)
        }
    }

    function nb(a) {
        var b = !1,
            c;
        return function () {
            b || (c = a(), b = !0);
            return c
        }
    }

    function ob(a) {
        var b = a;
        return function () {
            if (b) {
                var a = b;
                b = null;
                a()
            }
        }
    };

    function pb() {
        this.b = "";
        this.h = qb
    }
    pb.prototype.g = !0;
    pb.prototype.a = function () {
        return this.b
    };

    function rb(a) {
        if (a instanceof pb && a.constructor === pb && a.h === qb) return a.b;
        ua(a);
        return "type_error:TrustedResourceUrl"
    }
    var qb = {};

    function sb() {
        this.Y = "";
        this.Ba = tb
    }
    sb.prototype.g = !0;
    sb.prototype.a = function () {
        return this.Y
    };
    var ub = /^(?:(?:https?|mailto|ftp):|[^:/?#]*(?:[/?#]|$))/i,
        tb = {};

    function vb(a) {
        var b = new sb;
        b.Y = a;
        return b
    }
    vb("about:blank");

    function wb(a, b) {
        a.src = rb(b);
        (b = pa()) && a.setAttribute("nonce", b)
    };

    function xb(a) {
        this.a = a || q.document || document
    }

    function yb(a, b) {
        return a.a.createElement(String(b))
    }
    xb.prototype.contains = function (a, b) {
        if (!a || !b) return !1;
        if (a.contains && 1 == b.nodeType) return a == b || a.contains(b);
        if ("undefined" != typeof a.compareDocumentPosition) return a == b || !!(a.compareDocumentPosition(b) & 16);
        for (; b && a != b;) b = b.parentNode;
        return b == a
    };

    function zb(a) {
        Ab();
        var b = new pb;
        b.b = a;
        return b
    }
    var Ab = sa;

    function Bb() {
        return !(v(w, "iPad") || v(w, "Android") && !v(w, "Mobile") || v(w, "Silk")) && (v(w, "iPod") || v(w, "iPhone") || v(w, "Android") || v(w, "IEMobile"))
    };

    function C(a) {
        try {
            var b;
            if (b = !!a && null != a.location.href) a: {
                try {
                    Wa(a.foo);
                    b = !0;
                    break a
                } catch (c) { }
                b = !1
            }
            return b
        } catch (c) {
            return !1
        }
    }

    function Cb(a) {
        for (var b = q, c = 0; b && 40 > c++ && (!C(b) || !a(b)) ;) b = Db(b)
    }

    function Eb() {
        var a = q;
        Cb(function (b) {
            a = b;
            return !1
        });
        return a
    }

    function Db(a) {
        try {
            var b = a.parent;
            if (b && b != a) return b
        } catch (c) { }
        return null
    }

    function Fb(a, b) {
        var c = [q.top],
            d = [],
            e = 0;
        b = b || 1024;
        for (var f; f = c[e++];) {
            a && !C(f) || d.push(f);
            try {
                if (f.frames)
                    for (var g = f.frames.length, h = 0; h < g && c.length < b; ++h) c.push(f.frames[h])
            } catch (k) { }
        }
        return d
    }

    function Gb(a, b) {
        var c = a.createElement("script");
        wb(c, zb(b));
        return (a = a.getElementsByTagName("script")[0]) && a.parentNode ? (a.parentNode.insertBefore(c, a), c) : null
    }

    function Hb(a, b) {
        return b.getComputedStyle ? b.getComputedStyle(a, null) : a.currentStyle
    }

    function Ib(a, b, c) {
        var d = !1;
        void 0 === c || c || (d = Jb());
        return !d && !Kb() && (c = Math.random(), c < b) ? (c = Lb(q), a[Math.floor(c * a.length)]) : null
    }

    function Lb(a) {
        if (!a.crypto) return Math.random();
        try {
            var b = new Uint32Array(1);
            a.crypto.getRandomValues(b);
            return b[0] / 65536 / 65536
        } catch (c) {
            return Math.random()
        }
    }

    function Mb(a, b) {
        if (a)
            for (var c in a) Object.prototype.hasOwnProperty.call(a, c) && b.call(void 0, a[c], c, a)
    }

    function Nb(a) {
        var b = a.length;
        if (0 == b) return 0;
        for (var c = 305419896, d = 0; d < b; d++) c ^= (c << 5) + (c >> 2) + a.charCodeAt(d) & 4294967295;
        return 0 < c ? c : 4294967296 + c
    }
    var Kb = nb(function () {
        return v(w, "Google Web Preview") || 1E-4 > Math.random()
    }),
        Jb = nb(function () {
            return v(w, "MSIE")
        }),
        Ob = /^([0-9.]+)px$/,
        Pb = /^(-?[0-9.]{1,30})$/;

    function Qb(a) {
        return Pb.test(a) && (a = Number(a), !isNaN(a)) ? a : null
    }

    function Rb(a, b) {
        return b ? !/^false$/.test(a) : /^true$/.test(a)
    }

    function D(a) {
        return (a = Ob.exec(a)) ? +a[1] : null
    }

    function Sb(a, b) {
        try {
            return !(!a.frames || !a.frames[b])
        } catch (c) {
            return !1
        }
    }

    function Tb(a) {
        var b = {
            display: "none"
        };
        a.style.setProperty ? Mb(b, function (b, d) {
            a.style.setProperty(d, b, "important")
        }) : a.style.cssText = Ub(Vb(Wb(a.style.cssText), Xb(b, function (a) {
            return a + " !important"
        })))
    }
    var Vb = Object.assign || function (a, b) {
        for (var c = 1; c < arguments.length; c++) {
            var d = arguments[c];
            if (d)
                for (var e in d) Object.prototype.hasOwnProperty.call(d, e) && (a[e] = d[e])
        }
        return a
    };

    function Xb(a, b) {
        var c = {},
            d;
        for (d in a) Object.prototype.hasOwnProperty.call(a, d) && (c[d] = b.call(void 0, a[d], d, a));
        return c
    }

    function Ub(a) {
        var b = [];
        Mb(a, function (a, d) {
            null != a && "" !== a && b.push(d + ":" + a)
        });
        return b.length ? b.join(";") + ";" : ""
    }

    function Wb(a) {
        var b = {};
        if (a) {
            var c = /\s*:\s*/;
            a = (a || "").split(/\s*;\s*/);
            Da(a, function (a) {
                if (a) {
                    var d = a.split(c);
                    a = d[0];
                    d = d[1];
                    a && d && (b[a.toLowerCase()] = d)
                }
            })
        }
        return b
    };

    function Yb(a, b, c) {
        a.addEventListener && a.addEventListener(b, c, !1)
    };

    function Zb(a, b) {
        q.google_image_requests || (q.google_image_requests = []);
        var c = q.document.createElement("img");
        if (b) {
            var d = function (a) {
                b && b(a);
                c.removeEventListener && c.removeEventListener("load", d, !1);
                c.removeEventListener && c.removeEventListener("error", d, !1)
            };
            Yb(c, "load", d);
            Yb(c, "error", d)
        }
        c.src = a;
        q.google_image_requests.push(c)
    };

    function $b(a, b) {
        a = parseInt(a, 10);
        return isNaN(a) ? b : a
    }
    var ac = /^([\w-]+\.)*([\w-]{2,})(:[0-9]+)?$/;

    function bc(a, b) {
        return a ? (a = a.match(ac)) ? a[0] : b : b
    };

    function cc() {
        return "r20190206"
    }
    var dc = Rb("false", !1),
        ec = Rb("false", !1),
        fc = Rb("true", !1),
        gc = fc || !ec;

    function hc() {
        return bc("", "pagead2.googlesyndication.com")
    };

    function ic(a) {
        a = void 0 === a ? q : a;
        var b = a.context || a.AMP_CONTEXT_DATA;
        if (!b) try {
            b = a.parent.context || a.parent.AMP_CONTEXT_DATA
        } catch (c) { }
        try {
            if (b && b.pageViewId && b.canonicalUrl) return b
        } catch (c) { }
        return null
    }

    function jc(a) {
        return (a = a || ic()) ? C(a.master) ? a.master : null : null
    };

    function kc(a, b) {
        for (var c in a) Object.prototype.hasOwnProperty.call(a, c) && b.call(void 0, a[c], c, a)
    }

    function lc(a) {
        return !(!a || !a.call) && "function" === typeof a
    }

    function mc(a) {
        a = jc(ic(a)) || a;
        a.google_unique_id ? ++a.google_unique_id : a.google_unique_id = 1
    }

    function nc(a) {
        a = jc(ic(a)) || a;
        a = a.google_unique_id;
        return "number" === typeof a ? a : 0
    }
    var oc = !!window.google_async_iframe_id,
        pc = oc && window.parent || window;

    function qc() {
        if (oc && !C(pc)) {
            var a = "." + ib.domain;
            try {
                for (; 2 < a.split(".").length && !C(pc) ;) ib.domain = a = a.substr(a.indexOf(".") + 1), pc = window.parent
            } catch (b) { }
            C(pc) || (pc = window)
        }
        return pc
    }
    var rc = /(^| )adsbygoogle($| )/;

    function sc(a) {
        return dc && a.google_top_window || a.top
    }

    function tc(a) {
        a = sc(a);
        return C(a) ? a : null
    };

    function E(a) {
        a.google_ad_modifications || (a.google_ad_modifications = {});
        return a.google_ad_modifications
    }

    function F(a, b) {
        a: if (a = E(a).eids || [], a.indexOf) b = a.indexOf(b), b = 0 < b || 0 === b;
        else {
            for (var c = 0; c < a.length; c++)
                if (a[c] === b) {
                    b = !0;
                    break a
                }
            b = !1
        } return b
    }

    function uc(a, b) {
        a = E(a);
        a.tag_partners = a.tag_partners || [];
        a.tag_partners.push(b)
    }

    function vc(a, b, c) {
        for (var d = 0; d < a.length; ++d)
            if ((a[d].ad_slot || b) == b && (a[d].ad_tag_origin || c) == c) return a[d];
        return null
    };
    var wc = {
        overlays: 1,
        interstitials: 2,
        vignettes: 2,
        inserts: 3,
        immersives: 4,
        list_view: 5,
        full_page: 6
    };

    function yc(a) {
        z(this, a, zc, null)
    }
    u(yc, x);

    function Ac(a) {
        z(this, a, null, null)
    }
    u(Ac, x);

    function Bc(a) {
        z(this, a, null, null)
    }
    u(Bc, x);

    function Cc(a) {
        z(this, a, Dc, null)
    }
    u(Cc, x);
    var zc = [4];
    yc.prototype.K = function () {
        return A(this, 3)
    };
    var Dc = [6, 7, 9, 10, 11];

    function Ec(a) {
        z(this, a, Fc, null)
    }
    u(Ec, x);

    function Gc(a) {
        z(this, a, null, null)
    }
    u(Gc, x);

    function Hc(a) {
        z(this, a, Ic, null)
    }
    u(Hc, x);

    function Jc(a) {
        z(this, a, null, null)
    }
    u(Jc, x);
    var Fc = [1, 2, 5, 7, 16],
        Ic = [2];

    function Kc(a, b, c) {
        c = void 0 === c ? {} : c;
        this.error = a;
        this.context = b.context;
        this.line = b.line || -1;
        this.msg = b.message || "";
        this.file = b.file || "";
        this.id = b.id || "jserror";
        this.meta = c
    };
    var Lc = /^https?:\/\/(\w|-)+\.cdn\.ampproject\.(net|org)(\?|\/|$)/;

    function Mc(a, b) {
        this.a = a;
        this.b = b
    }

    function Nc(a, b, c) {
        this.url = a;
        this.a = b;
        this.ka = !!c;
        this.depth = oa(void 0) ? void 0 : null
    };

    function Oc() {
        this.g = "&";
        this.h = !1;
        this.b = {};
        this.i = 0;
        this.a = []
    }

    function Pc(a, b) {
        var c = {};
        c[a] = b;
        return [c]
    }

    function Qc(a, b, c, d, e) {
        var f = [];
        Mb(a, function (a, h) {
            (a = Rc(a, b, c, d, e)) && f.push(h + "=" + a)
        });
        return f.join(b)
    }

    function Rc(a, b, c, d, e) {
        if (null == a) return "";
        b = b || "&";
        c = c || ",$";
        "string" == typeof c && (c = c.split(""));
        if (a instanceof Array) {
            if (d = d || 0, d < c.length) {
                for (var f = [], g = 0; g < a.length; g++) f.push(Rc(a[g], b, c, d + 1, e));
                return f.join(c[d])
            }
        } else if ("object" == typeof a) return e = e || 0, 2 > e ? encodeURIComponent(Qc(a, b, c, d, e + 1)) : "...";
        return encodeURIComponent(String(a))
    }

    function Sc(a, b, c, d) {
        a.a.push(b);
        a.b[b] = Pc(c, d)
    }

    function Tc(a, b, c) {
        b = b + "//pagead2.googlesyndication.com" + c;
        var d = Uc(a) - c.length;
        if (0 > d) return "";
        a.a.sort(function (a, b) {
            return a - b
        });
        c = null;
        for (var e = "", f = 0; f < a.a.length; f++)
            for (var g = a.a[f], h = a.b[g], k = 0; k < h.length; k++) {
                if (!d) {
                    c = null == c ? g : c;
                    break
                }
                var n = Qc(h[k], a.g, ",$");
                if (n) {
                    n = e + n;
                    if (d >= n.length) {
                        d -= n.length;
                        b += n;
                        e = a.g;
                        break
                    } else a.h && (e = d, n[e - 1] == a.g && --e, b += n.substr(0, e), e = a.g, d = 0);
                    c = null == c ? g : c
                }
            }
        a = "";
        null != c && (a = e + "trn=" + c);
        return b + a
    }

    function Uc(a) {
        var b = 1,
            c;
        for (c in a.b) b = c.length > b ? c.length : b;
        return 3997 - b - a.g.length - 1
    };

    function Vc(a, b, c, d, e, f) {
        if ((d ? a.b : Math.random()) < (e || .01)) try {
            if (c instanceof Oc) var g = c;
            else g = new Oc, Mb(c, function (a, b) {
                var c = g,
                    d = c.i++;
                a = Pc(b, a);
                c.a.push(d);
                c.b[d] = a
            });
            var h = Tc(g, a.a, "/pagead/gen_204?id=" + b + "&");
            h && ("undefined" === typeof f ? Zb(h, null) : Zb(h, void 0 === f ? null : f))
        } catch (k) { }
    };

    function Wc(a, b) {
        this.start = a < b ? a : b;
        this.a = a < b ? b : a
    };

    function G(a, b, c) {
        this.b = b >= a ? new Wc(a, b) : null;
        this.a = c
    }

    function Xc(a, b) {
        var c = -1;
        b = "google_experiment_mod" + (void 0 === b ? "" : b);
        try {
            a.localStorage && (c = parseInt(a.localStorage.getItem(b), 10))
        } catch (d) {
            return null
        }
        if (0 <= c && 1E3 > c) return c;
        if (Kb()) return null;
        c = Math.floor(1E3 * Lb(a));
        try {
            if (a.localStorage) return a.localStorage.setItem(b, "" + c), c
        } catch (d) { }
        return null
    };
    var Yc = null;

    function Zc() {
        if (null === Yc) {
            Yc = "";
            try {
                var a = "";
                try {
                    a = q.top.location.hash
                } catch (c) {
                    a = q.location.hash
                }
                if (a) {
                    var b = a.match(/\bdeid=([\d,]+)/);
                    Yc = b ? b[1] : ""
                }
            } catch (c) { }
        }
        return Yc
    };

    function $c() {
        var a = q.performance;
        return a && a.now && a.timing ? Math.floor(a.now() + a.timing.navigationStart) : +new Date
    }

    function ad() {
        var a = void 0 === a ? q : a;
        return (a = a.performance) && a.now ? a.now() : null
    };

    function bd(a, b, c) {
        this.label = a;
        this.type = b;
        this.value = c;
        this.duration = 0;
        this.uniqueId = this.label + "_" + this.type + "_" + Math.random();
        this.slotId = void 0
    };
    var H = q.performance,
        cd = !!(H && H.mark && H.measure && H.clearMarks),
        dd = nb(function () {
            var a;
            if (a = cd) a = Zc(), a = !!a.indexOf && 0 <= a.indexOf("1337");
            return a
        });

    function ed() {
        var a = fd;
        this.b = [];
        this.g = a || q;
        var b = null;
        a && (a.google_js_reporting_queue = a.google_js_reporting_queue || [], this.b = a.google_js_reporting_queue, b = a.google_measure_js_timing);
        this.a = dd() || (null != b ? b : 1 > Math.random())
    }

    function gd(a) {
        a && H && dd() && (H.clearMarks("goog_" + a.uniqueId + "_start"), H.clearMarks("goog_" + a.uniqueId + "_end"))
    }
    ed.prototype.start = function (a, b) {
        if (!this.a) return null;
        var c = ad() || $c();
        a = new bd(a, b, c);
        b = "goog_" + a.uniqueId + "_start";
        H && dd() && H.mark(b);
        return a
    };

    function hd() {
        var a = id;
        this.I = jd;
        this.h = !0;
        this.g = null;
        this.L = this.a;
        this.b = void 0 === a ? null : a;
        this.i = !1
    }

    function kd(a, b, c, d, e) {
        try {
            if (a.b && a.b.a) {
                var f = a.b.start(b.toString(), 3);
                var g = c();
                var h = a.b;
                c = f;
                if (h.a && oa(c.value)) {
                    var k = ad() || $c();
                    c.duration = k - c.value;
                    var n = "goog_" + c.uniqueId + "_end";
                    H && dd() && H.mark(n);
                    h.a && h.b.push(c)
                }
            } else g = c()
        } catch (m) {
            h = a.h;
            try {
                gd(f), h = (e || a.L).call(a, b, new ld(md(m), m.fileName, m.lineNumber), void 0, d)
            } catch (p) {
                a.a(217, p)
            }
            if (!h) throw m;
        }
        return g
    }

    function nd(a, b) {
        var c = od;
        return function (d) {
            for (var e = [], f = 0; f < arguments.length; ++f) e[f] = arguments[f];
            return kd(c, a, function () {
                return b.apply(void 0, e)
            }, void 0, void 0)
        }
    }
    hd.prototype.a = function (a, b, c, d, e) {
        e = e || "jserror";
        try {
            var f = new Oc;
            f.h = !0;
            Sc(f, 1, "context", a);
            b.error && b.meta && b.id || (b = new ld(md(b), b.fileName, b.lineNumber));
            b.msg && Sc(f, 2, "msg", b.msg.substring(0, 512));
            b.file && Sc(f, 3, "file", b.file);
            0 < b.line && Sc(f, 4, "line", b.line);
            var g = b.meta || {};
            if (this.g) try {
                this.g(g)
            } catch (Y) { }
            if (d) try {
                d(g)
            } catch (Y) { }
            b = [g];
            f.a.push(5);
            f.b[5] = b;
            d = q;
            b = [];
            g = null;
            do {
                var h = d;
                if (C(h)) {
                    var k = h.location.href;
                    g = h.document && h.document.referrer || null
                } else k = g, g = null;
                b.push(new Nc(k || "", h));
                try {
                    d = h.parent
                } catch (Y) {
                    d = null
                }
            } while (d && h != d);
            k = 0;
            for (var n = b.length - 1; k <= n; ++k) b[k].depth = n - k;
            h = q;
            if (h.location && h.location.ancestorOrigins && h.location.ancestorOrigins.length == b.length - 1)
                for (n = 1; n < b.length; ++n) {
                    var m = b[n];
                    m.url || (m.url = h.location.ancestorOrigins[n - 1] || "", m.ka = !0)
                }
            var p = new Nc(q.location.href, q, !1);
            h = null;
            var t = b.length - 1;
            for (m = t; 0 <= m; --m) {
                var y = b[m];
                !h && Lc.test(y.url) && (h = y);
                if (y.url && !y.ka) {
                    p = y;
                    break
                }
            }
            y = null;
            var Ga = b.length && b[t].url;
            0 != p.depth && Ga && (y = b[t]);
            var N = new Mc(p, y);
            N.b && Sc(f, 6, "top", N.b.url || "");
            Sc(f, 7, "url", N.a.url || "");
            Vc(this.I, e, f, this.i, c)
        } catch (Y) {
            try {
                Vc(this.I, e, {
                    context: "ecmserr",
                    rctx: a,
                    msg: md(Y),
                    url: N && N.a.url
                }, this.i, c)
            } catch (mb) { }
        }
        return this.h
    };

    function md(a) {
        var b = a.toString();
        a.name && -1 == b.indexOf(a.name) && (b += ": " + a.name);
        a.message && -1 == b.indexOf(a.message) && (b += ": " + a.message);
        if (a.stack) {
            a = a.stack;
            var c = b;
            try {
                -1 == a.indexOf(c) && (a = c + "\n" + a);
                for (var d; a != d;) d = a, a = a.replace(/((https?:\/..*\/)[^\/:]*:\d+(?:.|\n)*)\2/, "$1");
                b = a.replace(/\n */g, "\n")
            } catch (e) {
                b = c
            }
        }
        return b
    }

    function ld(a, b, c) {
        Kc.call(this, Error(a), {
            message: a,
            file: void 0 === b ? "" : b,
            line: void 0 === c ? -1 : c
        })
    }
    ja(ld, Kc);

    function I(a) {
        a = void 0 === a ? "" : a;
        var b = Error.call(this);
        this.message = b.message;
        "stack" in b && (this.stack = b.stack);
        this.name = "TagError";
        this.message = a ? "adsbygoogle.push() error: " + a : "";
        Error.captureStackTrace ? Error.captureStackTrace(this, I) : this.stack = Error().stack || ""
    }
    ja(I, Error);

    function pd(a) {
        return 0 == (a.error && a.meta && a.id ? a.msg || md(a.error) : md(a)).indexOf("TagError")
    };
    var jd, od, fd = qc(),
        id = new ed;

    function qd(a) {
        null != a && (fd.google_measure_js_timing = a);
        fd.google_measure_js_timing || (a = id, a.a = !1, a.b != a.g.google_js_reporting_queue && (dd() && Da(a.b, gd), a.b.length = 0))
    }
    jd = new function () {
        var a = void 0 === a ? B : a;
        this.a = "http:" === a.location.protocol ? "http:" : "https:";
        this.b = Math.random()
    };
    od = new hd;
    "complete" == fd.document.readyState ? qd() : id.a && Yb(fd, "load", function () {
        qd()
    });

    function rd() {
        var a = [sd, td];
        od.g = function (b) {
            Da(a, function (a) {
                a(b)
            })
        }
    }

    function ud(a, b, c, d) {
        return kd(od, a, c, d, b)
    }

    function vd(a, b) {
        return nd(a, b)
    }
    var wd = od.a;

    function xd(a, b, c) {
        Vc(jd, a, b, "jserror" != a, c, void 0)
    }

    function yd(a, b, c, d) {
        return pd(b) ? (od.i = !0, od.a(a, b, .1, d, "puberror"), !1) : od.a(a, b, c, d)
    }

    function zd(a, b, c, d) {
        return pd(b) ? !1 : od.a(a, b, c, d)
    };

    function Ad(a, b) {
        this.ga = a;
        this.pa = b
    }

    function Bd(a) {
        var b = [].slice.call(arguments).filter(lb());
        if (!b.length) return null;
        var c = [],
            d = {};
        b.forEach(function (a) {
            c = c.concat(a.ga || []);
            d = Object.assign(d, a.pa)
        });
        return new Ad(c, d)
    }

    function Cd(a) {
        switch (a) {
            case 1:
                return new Ad(null, {
                    google_ad_semantic_area: "mc"
                });
            case 2:
                return new Ad(null, {
                    google_ad_semantic_area: "h"
                });
            case 3:
                return new Ad(null, {
                    google_ad_semantic_area: "f"
                });
            case 4:
                return new Ad(null, {
                    google_ad_semantic_area: "s"
                });
            default:
                return null
        }
    };
    var Dd = new Ad(["google-auto-placed"], {
        google_tag_origin: "qs"
    });
    var Ed = {},
        Fd = (Ed.google_ad_channel = !0, Ed.google_ad_host = !0, Ed);

    function Gd(a, b) {
        a.location.href && a.location.href.substring && (b.url = a.location.href.substring(0, 200));
        xd("ama", b, .01)
    }

    function Hd(a) {
        var b = {};
        Mb(Fd, function (c, d) {
            d in a && (b[d] = a[d])
        });
        return b
    };

    function Id(a, b, c) {
        c || (c = gc ? "https" : "http");
        q.location && "https:" == q.location.protocol && "http" == c && (c = "https");
        return [c, "://", a, b].join("")
    };
    var Jd = null;

    function Kd() {
        if (!dc) return !1;
        if (null != Jd) return Jd;
        Jd = !1;
        try {
            var a = tc(q);
            a && -1 != a.location.hash.indexOf("google_logging") && (Jd = !0);
            q.localStorage.getItem("google_logging") && (Jd = !0)
        } catch (b) { }
        return Jd
    }

    function Ld(a, b) {
        b = void 0 === b ? [] : b;
        if (Kd()) {
            if (!q.google_logging_queue) {
                q.google_logging_queue = [];
                var c = Id(hc(), "/pagead/js/logging_library.js");
                Gb(q.document, c)
            }
            q.google_logging_queue.push([a, b])
        }
    };

    function Md(a) {
        z(this, a, null, null)
    }
    u(Md, x);
    var Nd = null;

    function Od() {
        if (!Nd) {
            for (var a = q, b = a, c = 0; a && a != a.parent;)
                if (a = a.parent, c++, C(a)) b = a;
                else break;
            Nd = b
        }
        return Nd
    };
    var Pd = {
        c: "368226950",
        f: "368226951"
    },
        Qd = {
            c: "368226960",
            f: "368226961"
        },
        Rd = {
            c: "332260030",
            D: "332260031",
            J: "332260032"
        },
        Sd = {
            c: "332260040",
            D: "332260041",
            J: "332260042"
        },
        Td = {
            c: "368226500",
            f: "368226501"
        },
        Ud = {
            c: "36998750",
            f: "36998751"
        },
        Vd = {
            c: "633794000",
            F: "633794004"
        },
        Wd = {
            c: "633794002",
            F: "633794005"
        },
        Xd = {
            c: "221415700",
            f: "221415701"
        },
        Yd = {
            c: "221415800",
            f: "221415801"
        },
        Zd = {
            c: "231196899",
            f: "231196900"
        },
        $d = {
            c: "231196901",
            f: "231196902"
        },
        ae = {
            c: "4089040",
            Aa: "4089042"
        },
        be = {
            m: "20040067",
            c: "20040068",
            $: "1337"
        },
        ce = {
            c: "21060548",
            m: "21060549"
        },
        de = {
            c: "21060623",
            m: "21060624"
        },
        ee = {
            c: "22324606",
            f: "22324607"
        },
        fe = {
            c: "21062271",
            m: "21062272"
        },
        ge = {
            c: "21060849",
            ca: "21060850",
            U: "21060851",
            ba: "21060852",
            aa: "21060853"
        },
        J = {
            c: "182982000",
            f: "182982100"
        },
        he = {
            c: "182982200",
            f: "182982300"
        },
        ie = {
            c: "182983000",
            f: "182983100"
        },
        je = {
            c: "182983200",
            f: "182983300"
        },
        ke = {
            c: "182984000",
            f: "182984100",
            o: "182984400",
            s: "182984600"
        },
        le = {
            c: "182984200",
            f: "182984300",
            o: "182984500",
            s: "182984700"
        },
        me = {
            c: "229739148",
            f: "229739149"
        },
        ne = {
            c: "229739146",
            f: "229739147"
        },
        oe = {
            c: "21062571",
            f: "21062572"
        },
        pe = {
            c: "20040012",
            f: "20040013"
        },
        qe = {
            c: "21062908",
            T: "21062909",
            R: "21062910"
        };

    function re() {
        this.wasPlaTagProcessed = !1;
        this.wasReactiveAdConfigReceived = {};
        this.adCount = {};
        this.wasReactiveAdVisible = {};
        this.stateForType = {};
        this.reactiveTypeEnabledInAsfe = {};
        this.isReactiveTagFirstOnPage = this.wasReactiveAdConfigHandlerRegistered = this.wasReactiveTagRequestSent = !1;
        this.reactiveTypeDisabledByPublisher = {};
        this.tagSpecificState = {};
        this.adRegion = this.floatingAdsFillMessage = null;
        this.disablePageHeightCheck = !0;
        this.improveCollisionDetection = 0
    }

    function se(a) {
        a.google_reactive_ads_global_state || (a.google_reactive_ads_global_state = new re);
        return a.google_reactive_ads_global_state
    };

    function te(a) {
        a = a.document;
        var b = {};
        a && (b = "CSS1Compat" == a.compatMode ? a.documentElement : a.body);
        return b || {}
    }

    function K(a) {
        return te(a).clientWidth
    };

    function ue(a, b) {
        for (var c = [], d = a.length, e = 0; e < d; e++) c.push(a[e]);
        c.forEach(b, void 0)
    };

    function ve(a, b, c, d) {
        this.h = a;
        this.b = b;
        this.g = c;
        this.a = d
    }
    ve.prototype.toString = function () {
        return JSON.stringify({
            nativeQuery: this.h,
            occurrenceIndex: this.b,
            paragraphIndex: this.g,
            ignoreMode: this.a
        })
    };

    function we(a, b) {
        if (null == a.a) return b;
        switch (a.a) {
            case 1:
                return b.slice(1);
            case 2:
                return b.slice(0, b.length - 1);
            case 3:
                return b.slice(1, b.length - 1);
            case 0:
                return b;
            default:
                throw Error("Unknown ignore mode: " + a.a);
        }
    }

    function xe(a) {
        var b = [];
        ue(a.getElementsByTagName("p"), function (a) {
            100 <= ye(a) && b.push(a)
        });
        return b
    }

    function ye(a) {
        if (3 == a.nodeType) return a.length;
        if (1 != a.nodeType || "SCRIPT" == a.tagName) return 0;
        var b = 0;
        ue(a.childNodes, function (a) {
            b += ye(a)
        });
        return b
    }

    function ze(a) {
        return 0 == a.length || isNaN(a[0]) ? a : "\\" + (30 + parseInt(a[0], 10)) + " " + a.substring(1)
    };
    var Ae = {
        rectangle: 1,
        horizontal: 2,
        vertical: 4
    };

    function Be(a, b) {
        for (var c = ["width", "height"], d = 0; d < c.length; d++) {
            var e = "google_ad_" + c[d];
            if (!b.hasOwnProperty(e)) {
                var f = D(a[c[d]]);
                f = null === f ? null : Math.round(f);
                null != f && (b[e] = f)
            }
        }
    }

    function Ce(a, b) {
        return !((Pb.test(b.google_ad_width) || Ob.test(a.style.width)) && (Pb.test(b.google_ad_height) || Ob.test(a.style.height)))
    }

    function De(a, b) {
        try {
            var c = b.document.documentElement.getBoundingClientRect(),
                d = a.getBoundingClientRect();
            var e = {
                x: d.left - c.left,
                y: d.top - c.top
            }
        } catch (f) {
            e = null
        }
        return (a = e) ? a.y : 0
    }

    function Ee(a, b) {
        do {
            var c = Hb(a, b);
            if (c && "fixed" == c.position) return !1
        } while (a = a.parentElement);
        return !0
    }

    function Fe(a) {
        var b = 0,
            c;
        for (c in Ae) -1 != a.indexOf(c) && (b |= Ae[c]);
        return b
    }

    function Ge(a, b, c, d, e) {
        if (sc(a) != a) return tc(a) ? 3 : 16;
        if (!(488 > K(a))) return 4;
        if (!(a.innerHeight >= a.innerWidth)) return 5;
        var f = K(a);
        if (!f || (f - c) / f > d) a = 6;
        else {
            if (c = "true" != e.google_full_width_responsive) a: {
                c = K(a);
                for (b = b.parentElement; b; b = b.parentElement)
                    if ((d = Hb(b, a)) && (e = D(d.width)) && !(e >= c) && "visible" != d.overflow) {
                        c = !0;
                        break a
                    }
                c = !1
            }
            a = c ? 7 : !0
        }
        return a
    }

    function He(a, b, c, d) {
        var e = Ge(b, c, a, .3, d);
        if (!0 !== e) return e;
        e = K(b);
        a = e - a;
        a = e && 0 <= a ? !0 : e ? -10 > a ? 11 : 0 > a ? 14 : 12 : 10;
        return "true" == d.google_full_width_responsive || Ee(c, b) ? a : 9
    }

    function Ie(a, b) {
        if (3 == b.nodeType) return /\S/.test(b.data);
        if (1 == b.nodeType) {
            if (/^(script|style)$/i.test(b.nodeName)) return !1;
            try {
                var c = Hb(b, a)
            } catch (d) { }
            return !c || "none" != c.display && !("absolute" == c.position && ("hidden" == c.visibility || "collapse" == c.visibility))
        }
        return !1
    }

    function Je(a, b, c, d, e, f) {
        if (a = Hb(c, a)) {
            var g = D(a.paddingLeft) || 0;
            a = a.direction;
            d = e - d;
            if (f.google_ad_resize) g = -1 * (d + g) + "px";
            else {
                for (var h = f = 0; 100 > h && c; h++) f += c.offsetLeft + c.clientLeft - c.scrollLeft, c = c.offsetParent;
                g = f + g;
                g = "rtl" == a ? -1 * (d - g) + "px" : -1 * g + "px"
            }
            "rtl" == a ? b.style.marginRight = g : b.style.marginLeft = g;
            b.style.width = e + "px";
            b.style.zIndex = 30
        }
    };

    function L(a, b) {
        this.b = a;
        this.a = b
    }
    l = L.prototype;
    l.minWidth = function () {
        return this.b
    };
    l.height = function () {
        return this.a
    };
    l.G = function (a) {
        return 300 < a && 300 < this.a ? this.b : Math.min(1200, Math.round(a))
    };
    l.V = function (a) {
        return this.G(a) + "x" + this.height()
    };
    l.P = function () { };

    function M(a, b, c, d) {
        d = void 0 === d ? function (a) {
            return a
        } : d;
        var e;
        return a.style && a.style[c] && d(a.style[c]) || (e = Hb(a, b)) && e[c] && d(e[c]) || null
    }

    function Ke(a) {
        return function (b) {
            return b.minWidth() <= a
        }
    }

    function Le(a, b, c, d) {
        var e = a && Me(c, b),
            f = Ne(b, d);
        return function (a) {
            return !(e && a.height() >= f)
        }
    }

    function Oe(a) {
        return function (b) {
            return b.height() <= a
        }
    }

    function Me(a, b) {
        return De(a, b) < te(b).clientHeight - 100
    }

    function Pe(a, b) {
        var c = Infinity;
        do {
            var d = M(b, a, "height", D);
            d && (c = Math.min(c, d));
            (d = M(b, a, "maxHeight", D)) && (c = Math.min(c, d))
        } while ((b = b.parentElement) && "HTML" != b.tagName);
        return c
    }

    function Qe(a, b) {
        var c = M(b, a, "height", D);
        if (c) return c;
        var d = b.style.height;
        b.style.height = "inherit";
        c = M(b, a, "height", D);
        b.style.height = d;
        if (c) return c;
        c = Infinity;
        do (d = b.style && D(b.style.height)) && (c = Math.min(c, d)), (d = M(b, a, "maxHeight", D)) && (c = Math.min(c, d)); while ((b = b.parentElement) && "HTML" != b.tagName);
        return c
    }

    function Ne(a, b) {
        var c = a.google_unique_id;
        return b && 0 == ("number" === typeof c ? c : 0) ? Math.max(250, 2 * te(a).clientHeight / 3) : 250
    }

    function Re(a) {
        for (a = a.parentElement; a; a = a.parentElement) {
            var b = D(a.style.height || a.style.maxHeight);
            if (b) return b
        }
        return null
    };

    function Se(a) {
        if (1 != a.nodeType) var b = !1;
        else if (b = "INS" == a.tagName) a: {
            b = ["adsbygoogle-placeholder"];
            a = a.className ? a.className.split(/\s+/) : [];
            for (var c = {}, d = 0; d < a.length; ++d) c[a[d]] = !0;
            for (d = 0; d < b.length; ++d)
                if (!c[b[d]]) {
                    b = !1;
                    break a
                }
            b = !0
        }
        return b
    };

    function Te(a, b) {
        for (var c = 0; c < b.length; c++) {
            var d = b[c],
                e = Qa(d.Za);
            a[e] = d.value
        }
    };
    var Ue = {
        1: 1,
        2: 2,
        3: 3,
        0: 0
    };

    function Ve(a) {
        return null != a ? Ue[a] : a
    }
    var We = {
        1: 0,
        2: 1,
        3: 2,
        4: 3
    };

    function Xe(a, b) {
        if (!a) return !1;
        a = Hb(a, b);
        if (!a) return !1;
        a = a.cssFloat || a.styleFloat;
        return "left" == a || "right" == a
    }

    function Ye(a) {
        for (a = a.previousSibling; a && 1 != a.nodeType;) a = a.previousSibling;
        return a ? a : null
    }

    function Ze(a) {
        return !!a.nextSibling || !!a.parentNode && Ze(a.parentNode)
    };

    function $e(a, b, c) {
        this.a = q;
        this.i = a;
        this.h = b;
        this.g = c || null;
        this.b = !1
    }

    function af(a, b) {
        if (a.b) return !0;
        try {
            var c = a.a.localStorage.getItem("google_ama_settings");
            var d = c ? new Md(c ? JSON.parse(c) : null) : null
        } catch (h) {
            d = null
        }
        if (null !== d && ab(d, 2, !1)) return a = a.a.google_ama_state = a.a.google_ama_state || {}, a.eatf = !0, Ld(7, [!0, 0, !1]), !0;
        d = 0;
        var e = db(a.h, Cc, 1);
        for (c = 0; c < e.length; c++) {
            var f = e[c];
            if (1 == A(f, 8)) {
                var g = cb(f, Bc, 4);
                if (g && 2 == A(g, 1) && (d++, bf(a, f, b))) return a.b = !0, a = a.a.google_ama_state = a.a.google_ama_state || {}, a.placement = c, Ld(7, [!1, d, !0]), !0
            }
        }
        Ld(7, [!1, d, !1]);
        return !1
    }

    function bf(a, b, c) {
        if (1 != A(b, 8)) return !1;
        var d = cb(b, yc, 1);
        if (!d) return !1;
        if (d) {
            var e = A(d, 7);
            if (A(d, 1) || d.K() || 0 < A(d, 4).length) {
                var f = d.K(),
                    g = A(d, 1);
                var h = A(d, 4);
                e = A(d, 2);
                var k = A(d, 5);
                d = Ve(A(d, 6));
                var n = "";
                g && (n += g);
                f && (n += "#" + ze(f));
                if (h)
                    for (f = 0; f < h.length; f++) n += "." + ze(h[f]);
                e = (h = n) ? new ve(h, e, k, d) : null
            } else e = e ? new ve(e, A(d, 2), A(d, 5), Ve(A(d, 6))) : null
        } else e = null;
        if (!e) return !1;
        k = [];
        try {
            k = a.a.document.querySelectorAll(e.h)
        } catch (y) { }
        if (k.length) {
            h = k.length;
            if (0 < h) {
                d = Array(h);
                for (f = 0; f < h; f++) d[f] = k[f];
                k = d
            } else k = [];
            k = we(e, k);
            oa(e.b) && (h = e.b, 0 > h && (h += k.length), k = 0 <= h && h < k.length ? [k[h]] : []);
            if (oa(e.g)) {
                h = [];
                for (d = 0; d < k.length; d++) f = xe(k[d]), g = e.g, 0 > g && (g += f.length), 0 <= g && g < f.length && h.push(f[g]);
                k = h
            }
            e = k
        } else e = [];
        if (0 == e.length) return !1;
        e = e[0];
        k = A(b, 2);
        k = We[k];
        k = void 0 !== k ? k : null;
        if (!(h = null == k)) {
            a: {
                h = a.a;
                switch (k) {
                    case 0:
                        h = Xe(Ye(e), h);
                        break a;
                    case 3:
                        h = Xe(e, h);
                        break a;
                    case 2:
                        d = e.lastChild;
                        h = Xe(d ? 1 == d.nodeType ? d : Ye(d) : null, h);
                        break a
                }
                h = !1
            }
            if (c = !h && !(!c && 2 == k && !Ze(e))) c = 1 == k || 2 == k ? e : e.parentNode,
            c = !(c && !Se(c) && 0 >= c.offsetWidth); h = !c
        }
        if (h) return !1;
        c = cb(b, Ac, 3);
        h = {};
        c && (h.va = A(c, 1), h.ea = A(c, 2), h.Ea = !!A(c, 3));
        b = cb(b, Bc, 4) && A(cb(b, Bc, 4), 2) ? A(cb(b, Bc, 4), 2) : null;
        b = Bd(a.g, Cd(b));
        c = a.a;
        a = a.i;
        f = c.document;
        d = yb(new xb(f), "DIV");
        g = d.style;
        g.textAlign = "center";
        g.width = "100%";
        g.height = "auto";
        g.clear = h.Ea ? "both" : "none";
        h.Ma && Te(g, h.Ma);
        f = yb(new xb(f), "INS");
        g = f.style;
        g.display = "block";
        g.margin = "auto";
        g.backgroundColor = "transparent";
        h.va && (g.marginTop = h.va);
        h.ea && (g.marginBottom = h.ea);
        h.Da && Te(g, h.Da);
        d.appendChild(f);
        h = d;
        d = f;
        d.setAttribute("data-ad-format", "auto");
        f = [];
        if (g = b && b.ga) h.className = g.join(" ");
        g = d;
        g.className = "adsbygoogle";
        g.setAttribute("data-ad-client", a);
        f.length && g.setAttribute("data-ad-channel", f.join("+"));
        a: {
            try {
                a = h;
                switch (k) {
                    case 0:
                        e.parentNode && e.parentNode.insertBefore(a, e);
                        break;
                    case 3:
                        var m = e.parentNode;
                        if (m) {
                            var p = e.nextSibling;
                            if (p && p.parentNode != m)
                                for (; p && 8 == p.nodeType;) p = p.nextSibling;
                            m.insertBefore(a, p)
                        }
                        break;
                    case 1:
                        e.insertBefore(a, e.firstChild);
                        break;
                    case 2:
                        e.appendChild(a)
                }
                Se(e) && (e.setAttribute("data-init-display", e.style.display), e.style.display = "block");
                b: {
                    m = d;
                    m.setAttribute("data-adsbygoogle-status", "reserved");
                    m.className += " adsbygoogle-noablate";
                    p = {
                        element: m
                    };
                    var t = b && b.pa;
                    if (m.hasAttribute("data-pub-vars")) {
                        try {
                            t = JSON.parse(m.getAttribute("data-pub-vars"))
                        } catch (y) {
                            break b
                        }
                        m.removeAttribute("data-pub-vars")
                    }
                    t && (p.params = t);
                    (c.adsbygoogle = c.adsbygoogle || []).push(p)
                }
            } catch (y) {
                (t = h) && t.parentNode && (m = t.parentNode, m.removeChild(t), Se(m) && (m.style.display = m.getAttribute("data-init-display") || "none"));
                t = !1;
                break a
            }
            t = !0
        }
        return t
    };

    function cf() {
        this.b = new df(this);
        this.a = 0
    }

    function ef(a) {
        if (0 != a.a) throw Error("Already resolved/rejected.");
    }

    function df(a) {
        this.a = a
    }

    function ff(a) {
        switch (a.a.a) {
            case 0:
                break;
            case 1:
                a.b && a.b(a.a.h);
                break;
            case 2:
                a.g && a.g(a.a.g);
                break;
            default:
                throw Error("Unhandled deferred state.");
        }
    };

    function gf(a) {
        this.exception = a
    }

    function hf(a, b) {
        this.b = q;
        this.g = a;
        this.a = b
    }
    hf.prototype.start = function () {
        this.h()
    };
    hf.prototype.h = function () {
        try {
            switch (this.b.document.readyState) {
                case "complete":
                case "interactive":
                    af(this.g, !0);
                    jf(this);
                    break;
                default:
                    af(this.g, !1) ? jf(this) : this.b.setTimeout(za(this.h, this), 100)
            }
        } catch (a) {
            jf(this, a)
        }
    };

    function jf(a, b) {
        try {
            var c = a.a,
                d = new gf(b);
            ef(c);
            c.a = 1;
            c.h = d;
            ff(c.b)
        } catch (e) {
            a = a.a, b = e, ef(a), a.a = 2, a.g = b, ff(a.b)
        }
    };

    function kf(a) {
        Gd(a, {
            atf: 1
        })
    }

    function lf(a, b) {
        (a.google_ama_state = a.google_ama_state || {}).exception = b;
        Gd(a, {
            atf: 0
        })
    };

    function mf() {
        this.debugCard = null;
        this.debugCardRequested = !1
    };

    function nf(a, b) {
        if (!a) return !1;
        a = a.hash;
        if (!a || !a.indexOf) return !1;
        if (-1 != a.indexOf(b)) return !0;
        b = of(b);
        return "go" != b && -1 != a.indexOf(b) ? !0 : !1
    }

    function of(a) {
        var b = "";
        kc(a.split("_"), function (a) {
            b += a.substr(0, 2)
        });
        return b
    };

    function pf(a) {
        if (!a) return "";
        (a = a.toLowerCase()) && "ca-" != a.substring(0, 3) && (a = "ca-" + a);
        return a
    };

    function qf(a, b) {
        function c(a) {
            try {
                var b = new fb(a);
                return Fa(db(b, hb, 2), function (a) {
                    return 1 == A(a, 1)
                })
            } catch (f) {
                return null
            }
        }
        b = void 0 === b ? "" : b;
        a = tc(a) || a;
        a = rf(a);
        return b ? (b = pf(String(b)), a[b] ? c(a[b]) : null) : Fa(Ea(Ua(a), c), function (a) {
            return null != a
        })
    }

    function sf(a, b, c) {
        function d(a) {
            if (!a) return !1;
            a = new fb(a);
            var c;
            if (c = A(a, 3)) a = A(a, 3), c = 0 <= Ca(a, b);
            return c
        }
        c = void 0 === c ? "" : c;
        a = tc(a) || a;
        if (tf(a, b)) return !0;
        a = rf(a);
        return c ? (c = pf(String(c)), d(a[c])) : Ta(a, d)
    }

    function tf(a, b) {
        a = (a = (a = a.location && a.location.hash) && a.match(/forced_clientside_labs=([\d,]+)/)) && a[1];
        return !!a && 0 <= Ca(a.split(","), b.toString())
    }

    function rf(a) {
        try {
            return Vb({}, JSON.parse(a.localStorage.getItem("google_adsense_settings")))
        } catch (b) {
            return {}
        }
    };

    function uf(a) {
        if (q.google_apltlad || sc(q) != q) return !1;
        if (nf(q.location, "google_ads_preview")) return !0;
        if (!sf(q, 12, a.google_ad_client) || "google_ad_host" in a) return !1;
        q.google_apltlad = !0;
        return F(q, Pd.f)
    };
    var vf = {
        9: "400",
        10: "100",
        13: "0.001",
        19: "0.01",
        22: "0.01",
        24: "0.05",
        28: "0.001",
        29: "0.01",
        34: "0.001",
        40: "0.15",
        60: "0.03",
        66: "0.1",
        76: "0.004",
        77: "true",
        78: "0.1",
        79: "1200",
        82: "3",
        83: "1.0",
        96: "700",
        97: "10",
        98: "0.01",
        99: "600",
        100: "100",
        103: "0.01",
        111: "0.1",
        117: "0.02",
        118: "false",
        120: "0",
        121: "1000",
        126: "0.001",
        128: "false",
        129: "0.02",
        135: "0.01",
        136: "0.02",
        137: "0.01",
        142: "1",
        143: "0.1",
        146: "0.10",
        149: "0",
        150: "1000",
        152: "700",
        153: "100",
        154: "0.001",
        155: "1",
        157: "1",
        158: "20",
        159: "0.001",
        160: "240",
        161: "30",
        162: "0.1",
        165: "0.02",
        166: "100",
        167: "2",
        169: "500",
        170: "30",
        171: "0.01",
        172: "0.001",
        173: "800",
        174: "2",
        175: "0.01"
    };
    var wf = null;

    function xf() {
        this.a = vf
    }

    function O(a, b) {
        a = parseFloat(a.a[b]);
        return isNaN(a) ? 0 : a
    }

    function yf() {
        wf || (wf = new xf);
        return wf
    };

    function zf(a, b, c) {
        var d = "script";
        d = void 0 === d ? "" : d;
        var e = a.createElement("link");
        try {
            e.rel = "preload";
            if (v("preload", "stylesheet")) var f = rb(b);
            else {
                if (b instanceof pb) var g = rb(b);
                else {
                    if (b instanceof sb)
                        if (b instanceof sb && b.constructor === sb && b.Ba === tb) var h = b.Y;
                        else ua(b), h = "type_error:SafeUrl";
                    else {
                        if (b instanceof sb) var k = b;
                        else b = "object" == typeof b && b.g ? b.a() : String(b), ub.test(b) || (b = "about:invalid#zClosurez"), k = vb(b);
                        h = k.a()
                    }
                    g = h
                }
                f = g
            }
            e.href = f
        } catch (n) {
            return
        }
        d && (e.as = d);
        c && e.setAttribute("nonce", c);
        if (a = a.getElementsByTagName("head")[0]) try {
            a.appendChild(e)
        } catch (n) { }
    };

    function Af(a) {
        var b = {},
            c = {};
        a = (c.enable_page_level_ads = (b.pltais = !0, b), c.google_ad_client = a, c);
        a.enable_page_level_ads.google_ad_channel = "AutoInsertAutoAdCode";
        return a
    };

    function td(a) {
        try {
            var b = E(q).eids || [];
            null != b && 0 < b.length && (a.eid = b.join(","))
        } catch (c) { }
    }

    function sd(a) {
        a.shv = cc()
    }
    od.h = !dc;

    function Bf(a, b) {
        return De(b, a) + M(b, a, "height", D)
    };
    var Cf = {
        0: [
            [null, [
                [21062754],
                [21062755]
            ]]
        ],
        5: [
            [1, [
                [21062810],
                [21062811]
            ]]
        ]
    };

    function Df(a) {
        z(this, a, Ef, null)
    }
    u(Df, x);

    function Ff(a) {
        z(this, a, Gf, null)
    }
    u(Ff, x);

    function Hf(a) {
        z(this, a, If, Jf)
    }
    u(Hf, x);

    function Kf(a) {
        z(this, a, Lf, Mf)
    }
    u(Kf, x);
    var Ef = [2],
        Gf = [2];
    Ff.prototype.K = function () {
        return ab(this, 1, 0)
    };
    var If = [5],
        Jf = [
            [1, 2, 3, 6]
        ],
        Lf = [2, 8],
        Mf = [
            [3, 4, 5],
            [6, 7]
        ];

    function Nf(a, b) {
        switch (b) {
            case 1:
                return ab(a, 1, 0);
            case 2:
                return ab(a, 2, 0);
            case 3:
                return ab(a, 3, 0);
            case 6:
                return ab(a, 6, 0);
            default:
                return null
        }
    }

    function Of() {
        var a = {};
        this.a = (a[1] = {}, a[2] = {}, a[3] = {}, a[6] = {}, a)
    }
    ta(Of);

    function Pf(a) {
        var b = Of.ja().a;
        Da(a, function (a) {
            var c = $a(a, Jf[0]),
                e = Nf(a, c);
            e && (b[c][e] = eb(a))
        })
    };

    function Qf(a, b) {
        var c = this,
            d = void 0 === b ? {} : b;
        b = void 0 === d.Ha ? !1 : d.Ha;
        var e = void 0 === d.La ? {} : d.La;
        d = void 0 === d.Ta ? [] : d.Ta;
        this.h = a;
        this.i = b;
        this.a = e;
        this.g = d;
        this.b = {};
        if (a = Zc()) a = a.split(",") || [], Da(a, function (a) {
            (a = parseInt(a, 10)) && (c.b[a] = !0)
        })
    }

    function Rf(a) {
        var b = a.h[5];
        b && (delete a.h[5], Da(b, function (b) {
            b = new Df(b);
            !cb(b, Kf, 3) && (b = Sf(a, b)) && (a.g.push(b.K()), (b = db(b, Hf, 2)) && Pf(b))
        }))
    }

    function Sf(a, b) {
        var c = db(b, Ff, 2),
            d = c.length;
        if (!d) return null;
        var e = ab(b, 4, 0);
        b = d * ab(b, 1, 0);
        if (!e) return Tf(a, c, b / 1E3);
        d = null != a.a[e] ? a.a[e] : 1E3;
        if (0 >= d) return null;
        c = Tf(a, c, b / d);
        a.a[e] = c ? 0 : d - b;
        return c
    }

    function Tf(a, b, c) {
        var d = a.b,
            e = Fa(b, function (a) {
                return !!d[a.K()]
            });
        return e ? e : a.i ? null : Ib(b, c, !1)
    };

    function Uf() {
        Qf.call(this, Cf && Va(Cf) || {})
    }
    ja(Uf, Qf);
    ta(Uf);
    var Vf = new G(100, 199, ""),
        Wf = new G(200, 399, ""),
        Xf = new G(400, 499, ""),
        Yf = new G(500, 599, ""),
        Zf = new G(600, 699, ""),
        $f = new G(700, 799, ""),
        ag = new G(800, 899, ""),
        bg = new G(1, 399, "3");

    function P(a, b) {
        b && a.push(b)
    }

    function cg(a, b) {
        for (var c = [], d = 1; d < arguments.length; ++d) c[d - 1] = arguments[d];
        d = tc(a) || a;
        d = (d = (d = d.location && d.location.hash) && (d.match(/google_plle=([\d,]+)/) || d.match(/deid=([\d,]+)/))) && d[1];
        var e;
        if (e = !!d) a: {
            d = Aa(v, d);
            e = c.length;
            for (var f = r(c) ? c.split("") : c, g = 0; g < e; g++)
                if (g in f && d.call(void 0, f[g], g, c)) {
                    e = !0;
                    break a
                }
            e = !1
        }
        return e
    }

    function Q(a, b, c) {
        for (var d = 0; d < c.length; d++)
            if (cg(a, c[d])) return c[d];
        return Ib(c, b)
    }

    function R(a, b, c, d, e, f) {
        f = void 0 === f ? 1 : f;
        for (var g = 0; g < e.length; g++)
            if (cg(a, e[g])) return e[g];
        f = void 0 === f ? 1 : f;
        0 >= d ? c = null : (g = new Wc(c, c + d - 1), (d = d % f || d / f % e.length) || (d = b.b, d = !(d.start <= g.start && d.a >= g.a)), d ? c = null : (a = Xc(a, b.a), c = null !== a && g.start <= a && g.a >= a ? e[Math.floor((a - c) / f) % e.length] : null));
        return c
    };

    function dg(a, b, c) {
        if (C(a.document.getElementById(b).contentWindow)) a = a.document.getElementById(b).contentWindow, b = a.document, b.body && b.body.firstChild || (/Firefox/.test(navigator.userAgent) ? b.open("text/html", "replace") : b.open(), a.google_async_iframe_close = !0, b.write(c));
        else {
            a = a.document.getElementById(b).contentWindow;
            c = String(c);
            b = ['"'];
            for (var d = 0; d < c.length; d++) {
                var e = c.charAt(d),
                    f = e.charCodeAt(0),
                    g = d + 1,
                    h;
                if (!(h = Oa[e])) {
                    if (!(31 < f && 127 > f))
                        if (f = e, f in Pa) e = Pa[f];
                        else if (f in Oa) e = Pa[f] = Oa[f];
                        else {
                            h = f.charCodeAt(0);
                            if (31 < h && 127 > h) e = f;
                            else {
                                if (256 > h) {
                                    if (e = "\\x", 16 > h || 256 < h) e += "0"
                                } else e = "\\u", 4096 > h && (e += "0");
                                e += h.toString(16).toUpperCase()
                            }
                            e = Pa[f] = e
                        }
                    h = e
                }
                b[g] = h
            }
            b.push('"');
            a.location.replace("javascript:" + b.join(""))
        }
    };
    var eg = null;

    function S(a, b, c, d) {
        d = void 0 === d ? !1 : d;
        L.call(this, a, b);
        this.M = c;
        this.Ja = d
    }
    ja(S, L);
    S.prototype.Z = function () {
        return this.M
    };
    S.prototype.P = function (a, b, c, d) {
        var e = this;
        if (!c.google_ad_resize) {
            d.style.height = this.height() + "px";
            var f = F(a, ke.c) || F(a, ke.f) || F(a, J.c) || F(a, Vd.c),
                g = F(a, ke.s) || F(a, Vd.F);
            b = F(a, ke.o) || g || F(a, J.f);
            if (f || b) c.ovlp = !0;
            var h = function () {
                if (g) return !0;
                var a = Re(d);
                if (a) return a < e.height()
            };
            f = f && h();
            b = b && h();
            f ? (c.rpe = !1, c.rpeua = !1) : b && (c.rpe = !0, c.rpeua = g);
            if (F(a, Rd.c) || F(a, Rd.D) || F(a, Rd.J)) c.ovlp = !0
        }
    };

    function fg(a) {
        return function (b) {
            return !!(b.M & a)
        }
    };

    function gg(a) {
        throw new I(a);
    }
    var hg = {},
        ig = (hg.image_stacked = 1 / 1.91, hg.image_sidebyside = 1 / 3.82, hg.mobile_banner_image_sidebyside = 1 / 3.82, hg.pub_control_image_stacked = 1 / 1.91, hg.pub_control_image_sidebyside = 1 / 3.82, hg.pub_control_image_card_stacked = 1 / 1.91, hg.pub_control_image_card_sidebyside = 1 / 3.74, hg.pub_control_text = 0, hg.pub_control_text_card = 0, hg),
        jg = {},
        kg = (jg.image_stacked = 80, jg.image_sidebyside = 0, jg.mobile_banner_image_sidebyside = 0, jg.pub_control_image_stacked = 80, jg.pub_control_image_sidebyside = 0, jg.pub_control_image_card_stacked = 85, jg.pub_control_image_card_sidebyside = 0, jg.pub_control_text = 80, jg.pub_control_text_card = 80, jg),
        lg = {},
        mg = (lg.pub_control_image_stacked = 100, lg.pub_control_image_sidebyside = 200, lg.pub_control_image_card_stacked = 150, lg.pub_control_image_card_sidebyside = 250, lg.pub_control_text = 100, lg.pub_control_text_card = 150, lg);

    function ng(a) {
        var b = 0;
        a.H && b++;
        a.u && b++;
        a.v && b++;
        if (3 > b) return gg("Tags data-matched-content-ui-type, data-matched-content-columns-num and data-matched-content-rows-num should be set together."), null;
        b = a.H.split(",");
        var c = a.v.split(",");
        a = a.u.split(",");
        if (b.length !== c.length || b.length !== a.length) return gg('Lengths of parameters data-matched-content-ui-type, data-matched-content-columns-num and data-matched-content-rows-num must match. Example: \n data-matched-content-rows-num="4,2"\ndata-matched-content-columns-num="1,6"\ndata-matched-content-ui-type="image_stacked,image_card_sidebyside"'), null;
        if (2 < b.length) return gg("The parameter length of attribute data-matched-content-ui-type, data-matched-content-columns-num and data-matched-content-rows-num is too long. At most 2 parameters for each attribute are needed: one for mobile and one for desktop, while " + ("you are providing " + b.length + ' parameters. Example: \n data-matched-content-rows-num="4,2"\ndata-matched-content-columns-num="1,6"\ndata-matched-content-ui-type="image_stacked,image_card_sidebyside".')), null;
        for (var d = [], e = [], f = 0; f < b.length; f++) {
            var g = Number(c[f]);
            if (Number.isNaN(g) || 0 === g) return gg("Wrong value '" + c[f] + "' for data-matched-content-rows-num."), null;
            d.push(g);
            g = Number(a[f]);
            if (Number.isNaN(g) || 0 === g) return gg("Wrong value '" + a[f] + "' for data-matched-content-columns-num."), null;
            e.push(g)
        }
        return {
            v: d,
            u: e,
            ma: b,
            Ya: !1
        }
    }

    function og(a) {
        return 1200 <= a ? {
            width: 1200,
            height: 600
        } : 850 <= a ? {
            width: a,
            height: Math.floor(.5 * a)
        } : 550 <= a ? {
            width: a,
            height: Math.floor(.6 * a)
        } : 468 <= a ? {
            width: a,
            height: Math.floor(.7 * a)
        } : {
            width: a,
            height: Math.floor(3.44 * a)
        }
    };

    function pg(a, b, c, d, e, f, g, h, k, n, m, p, t) {
        this.za = a;
        this.a = b;
        this.M = void 0 === c ? null : c;
        this.xa = void 0 === d ? null : d;
        this.b = void 0 === e ? null : e;
        this.g = void 0 === f ? null : f;
        this.I = void 0 === g ? !1 : g;
        this.L = void 0 === h ? !1 : h;
        this.oa = void 0 === k ? null : k;
        this.ta = void 0 === n ? null : n;
        this.h = void 0 === m ? null : m;
        this.i = void 0 === p ? null : p;
        this.wa = void 0 === t ? null : t;
        this.ya = this.na = this.la = null
    }

    function qg(a, b, c) {
        null != a.M && (c.google_responsive_formats = a.M);
        null != a.xa && (c.google_safe_for_responsive_override = a.xa);
        null != a.b && (!0 === a.b ? c.google_full_width_responsive_allowed = !0 : (c.google_full_width_responsive_allowed = !1, c.gfwrnwer = a.b));
        null != a.g && !0 !== a.g && (c.gfwrnher = a.g);
        a.I && (c.google_bfa = a.I);
        a.L && (c.ebfa = a.L);
        var d = a.a.G(b),
            e = a.a.height();
        c.google_ad_resize || (c.google_ad_width = d, c.google_ad_height = e, c.google_ad_format = a.a.V(b), c.google_responsive_auto_format = a.za, c.google_ad_resizable = !0, c.google_override_format = 1, c.google_loader_features_used = 128, !0 === a.b && (c.gfwrnh = a.a.height() + "px"));
        null != a.oa && (c.gfwroml = a.oa);
        null != a.ta && (c.gfwromr = a.ta);
        null != a.h && (c.gfwroh = a.h, c.google_resizing_height = a.h);
        null != a.i && (c.gfwrow = a.i, c.google_resizing_width = a.i);
        null != a.wa && (c.gfwroz = a.wa);
        null != a.la && (c.gml = a.la);
        null != a.na && (c.gmr = a.na);
        null != a.ya && (c.gzi = a.ya);
        b = qc();
        b = tc(b) || b;
        if (nf(b.location, "google_responsive_slot_debug") || cg(b, J.c, J.f)) c.ds = "outline:thick dashed " + (d && e ? !0 !== a.b || !0 !== a.g ? "#ffa500" : "#0f0" : "#f00") + " !important;"
    };
    var ba = ["google_content_recommendation_ui_type", "google_content_recommendation_columns_num", "google_content_recommendation_rows_num"];

    function rg(a, b) {
        L.call(this, a, b)
    }
    ja(rg, L);
    rg.prototype.G = function (a) {
        return Math.min(1200, Math.max(this.minWidth(), Math.round(a)))
    };

    function sg(a, b) {
        tg(a, b);
        if ("pedestal" == b.google_content_recommendation_ui_type) return ug(a, Math.floor(4.378 * a));
        var c = Bb();
        468 > a ? c ? (c = a - 8 - 8, c = Math.floor(c / 1.91 + 70) + Math.floor(11 * (c * ig.mobile_banner_image_sidebyside + kg.mobile_banner_image_sidebyside) + 96), a = {
            O: a,
            N: c,
            u: 1,
            v: 12,
            H: "mobile_banner_image_sidebyside"
        }) : (a = og(a), a = {
            O: a.width,
            N: a.height,
            u: 1,
            v: 13,
            H: "image_sidebyside"
        }) : (a = og(a), a = {
            O: a.width,
            N: a.height,
            u: 4,
            v: 2,
            H: "image_stacked"
        });
        vg(b, a);
        return ug(a.O, a.N)
    }

    function ug(a, b) {
        return new pg(9, new rg(a, b))
    }

    function wg(a, b) {
        tg(a, b);
        var c = ng({
            v: b.google_content_recommendation_rows_num,
            u: b.google_content_recommendation_columns_num,
            H: b.google_content_recommendation_ui_type
        });
        if (null == c) var d = null;
        else {
            var e = 2 === c.ma.length && 468 <= a ? 1 : 0;
            d = c.ma[e];
            d = 0 === d.indexOf("pub_control_") ? d : "pub_control_" + d;
            var f = c.u[e];
            for (var g = mg[d], h = f; a / h < g && 1 < h;) h--;
            h !== f && q.console && window.console.warn("adsbygoogle warning: data-matched-content-columns-num " + f + " is too large. Using " + h + " instead.");
            f = h;
            c = c.v[e];
            e = Math.floor(((a - 8 * f - 8) / f * ig[d] + kg[d]) * c + 8 * c + 8);
            1500 < a ? (gg("Calculated slot width is too large: " + a), a = null) : 1500 < e ? (gg("Calculated slot height is too large: " + e), a = null) : a = {
                width: a,
                height: e
            };
            d = {
                O: a.width,
                N: a.height,
                u: f,
                v: c,
                H: d
            }
        }
        if (!d) return ug(0, 0);
        vg(b, d);
        return ug(d.O, d.N)
    }

    function tg(a, b) {
        if (0 >= a) throw new I("Invalid responsive width from Matched Content slot " + b.google_ad_slot + ": " + a + ". Please ensure to put this Matched Content slot into a non-zero width div container.");
    }

    function vg(a, b) {
        a.google_content_recommendation_ui_type = b.H;
        a.google_content_recommendation_columns_num = b.u;
        a.google_content_recommendation_rows_num = b.v
    };

    function xg(a, b) {
        L.call(this, a, b)
    }
    ja(xg, L);
    xg.prototype.G = function () {
        return this.minWidth()
    };
    xg.prototype.P = function (a, b, c, d) {
        var e = this,
            f = this.G(b);
        Je(a, d, d.parentElement, b, f, c);
        if (!c.google_ad_resize) {
            d.style.height = this.height() + "px";
            b = F(a, ke.c) || F(a, ke.f) || F(a, J.c) || F(a, Vd.c);
            var g = F(a, ke.s) || F(a, Vd.F);
            a = F(a, ke.o) || g || F(a, J.f);
            if (b || a) c.ovlp = !0;
            f = function () {
                if (g) return !0;
                var a = Re(d);
                if (a) return a < e.height()
            };
            b = b && f();
            a = a && f();
            b ? (c.rpe = !1, c.rpeua = !1) : a && (c.rpe = !0, c.rpeua = g)
        }
    };

    function yg(a) {
        return function (b) {
            for (var c = a.length - 1; 0 <= c; --c)
                if (!a[c](b)) return !1;
            return !0
        }
    }

    function zg(a, b, c) {
        for (var d = a.length, e = null, f = 0; f < d; ++f) {
            var g = a[f];
            if (b(g)) {
                if (!c || c(g)) return g;
                null === e && (e = g)
            }
        }
        return e
    };
    var T = [new S(970, 90, 2), new S(728, 90, 2), new S(468, 60, 2), new S(336, 280, 1), new S(320, 100, 2), new S(320, 50, 2), new S(300, 600, 4), new S(300, 250, 1), new S(250, 250, 1), new S(234, 60, 2), new S(200, 200, 1), new S(180, 150, 1), new S(160, 600, 4), new S(125, 125, 1), new S(120, 600, 4), new S(120, 240, 4), new S(120, 120, 1, !0)],
        Ag = [T[6], T[12], T[3], T[0], T[7], T[14], T[1], T[8], T[10], T[4], T[15], T[2], T[11], T[5], T[13], T[9], T[16]];
    var Bg = {
        5378560161704604: !0,
        "9932189667849434": !0,
        0x6abea55410402: !0,
        6196110725877329: !0,
        5186343770550892: !0,
        0xd0ac265d23fe7: !0,
        0xa145bc7b4f4b9: !0,
        6207070263630215: !0,
        8194376114167709: !0,
        7677430104552677: !0,
        7409460644561046: !0,
        8319194293021183: !0,
        4606740807385097: !0,
        0x6a24e3c1c9935: !0,
        7415312055569465: !0,
        0xfff9f44c6345d: !0,
        5812266126224098: !0,
        8715918894710040: !0,
        6751482248701881: !0,
        6771940464972938: !0,
        0x3d3c6c533953c: !0,
        0x63321a46e82ec: !0,
        "9468071090686512": !0,
        5853386751525604: !0,
        6535472412829264: !0,
        0xcb2fc7403206b: !0,
        0x3d2dd2efab615: !0,
        "9762329074683820": !0,
        0xde9c1cd96fc8b: !0,
        8276876859409269: !0,
        6377770909536887: !0,
        0x5f2c014a678e0: !0,
        0x86f8ff5ee31b1: !0,
        5035524433802133: !0,
        0xca35bd7a2c187: !0,
        "9401881776605044": !0,
        8333245742172016: !0,
        0xe086d134770ff: !0,
        7735759473986562: !0
    };

    function Cg(a, b, c, d, e) {
        "false" != e.google_full_width_responsive || c.location && "#gfwrffwaifhp" == c.location.hash ? "auto" == b || 0 < (Fe(b) & 1) || "autorelaxed" == b && (e.google_full_width_responsive || F(c, me.f)) || Dg(b) || e.google_ad_resize ? (b = He(a, c, d, e), c = !0 !== b ? {
            j: a,
            l: b
        } : {
            j: K(c) || a,
            l: !0
        }) : c = {
            j: a,
            l: 2
        } : c = {
            j: a,
            l: 1
        };
        b = c.l;
        return !0 !== b ? {
            j: a,
            l: b
        } : d.parentElement ? {
            j: c.j,
            l: b
        } : {
            j: a,
            l: b
        }
    }

    function Eg(a, b, c, d, e) {
        var f = ud(247, wd, function () {
            return Cg(a, b, c, d, e)
        }),
            g = f.j;
        f = f.l;
        var h = !0 === f,
            k = D(d.style.width),
            n = D(d.style.height),
            m = Fg(g, b, c, d, e, h);
        g = m.C;
        h = m.B;
        var p = m.w,
            t = m.A,
            y = m.Z;
        m = m.Ka;
        var Ga = Gg(b, y),
            N, Y = (N = M(d, c, "marginLeft", D)) ? N + "px" : "",
            mb = (N = M(d, c, "marginRight", D)) ? N + "px" : "";
        N = M(d, c, "zIndex") || "";
        return new pg(Ga, g, y, m, f, h, p, t, Y, mb, n, k, N)
    }

    function Dg(a) {
        return "auto" == a || /^((^|,) *(horizontal|vertical|rectangle) *)+$/.test(a)
    }

    function Fg(a, b, c, d, e, f) {
        b = "auto" == b ? .25 >= a / Math.min(1200, K(c)) ? 4 : 3 : Fe(b);
        var g = !1,
            h = !1,
            k = Hg(c, e.google_ad_client);
        if (k && 488 > K(c) || !k && Bb()) {
            var n = Ee(d, c);
            var m = Me(d, c);
            g = !m && n;
            h = m && n
        }
        m = (g || k ? Ag : T).slice(0);
        var p = 488 > K(c),
            t = [Ke(a), Le(p, c, d, h), fg(b)];
        null != e.google_max_responsive_height && t.push(Oe(e.google_max_responsive_height));
        k || t.push(Ig(p));
        p = [function (a) {
            return !a.Ja
        }];
        if (g || h) g = g && !k ? Pe(c, d) : Qe(c, d), p.push(Oe(g));
        var y = zg(m, yg(t), yg(p));
        if (!y) throw new I("No slot size for availableWidth=" + a);
        g = ud(248, wd, function () {
            var b;
            a: if (f) {
                if (e.gfwrnh && (b = D(e.gfwrnh))) {
                    b = {
                        C: new xg(a, b),
                        B: !0,
                        w: !1,
                        A: !1
                    };
                    break a
                }
                if (Hg(c, e.google_ad_client) || "true" == e.google_full_width_responsive || !Me(d, c) || e.google_resizing_allowed) {
                    b = !1;
                    var g = te(c).clientHeight,
                        h = De(d, c),
                        k = c.google_lpabyc;
                    var m = De(d, c);
                    var n = te(c).clientHeight;
                    if ((m = 0 == n ? null : m / n) && 2 < m && !c.google_bfabyc && (!k || h - k > g) && (g = .9 * te(c).clientHeight, h = Math.min(g, Jg(c, d, e)), g && h == g)) {
                        h = c.google_pbfabyc;
                        b = !h;
                        if (F(c, Sd.D) || F(c, Sd.J)) {
                            c.google_bfabyc = De(d, c) + g;
                            b = {
                                C: new xg(a, Math.floor(g)),
                                B: !0,
                                w: !0,
                                A: !0
                            };
                            break a
                        }
                        h || (c.google_pbfabyc = De(d, c) + g)
                    }
                    g = a / 1.2;
                    h = Math.min(g, Jg(c, d, e));
                    if (h < .5 * g || 100 > h) h = g;
                    b = {
                        C: new xg(a, Math.floor(h)),
                        B: h < g ? 102 : !0,
                        w: !1,
                        A: b
                    }
                } else b = {
                    C: new xg(a, y.height()),
                    B: 101,
                    w: !1,
                    A: !1
                }
            } else b = {
                C: y,
                B: 100,
                w: !1,
                A: !1
            };
            return b
        });
        return {
            C: g.C,
            B: g.B,
            w: g.w,
            A: g.A,
            Z: b,
            Ka: n
        }
    }

    function Jg(a, b, c) {
        return c.google_resizing_allowed || "true" == c.google_full_width_responsive ? Infinity : Pe(a, b)
    }

    function Gg(a, b) {
        if ("auto" == a) return 1;
        switch (b) {
            case 2:
                return 2;
            case 1:
                return 3;
            case 4:
                return 4;
            case 3:
                return 5;
            case 6:
                return 6;
            case 5:
                return 7;
            case 7:
                return 8
        }
        throw Error("bad mask");
    }

    function Ig(a) {
        return function (b) {
            return !(320 == b.minWidth() && (a && 50 == b.height() || !a && 100 == b.height()))
        }
    }

    function Hg(a, b) {
        return F(a, Vd.F) && 1 != Bg[parseInt(b.match(/\d+$/), 10)]
    };
    var Kg = {
        "image-top": function (a) {
            return 600 >= a ? 284 + .414 * (a - 250) : 429
        },
        "image-middle": function (a) {
            return 500 >= a ? 196 - .13 * (a - 250) : 164 + .2 * (a - 500)
        },
        "image-side": function (a) {
            return 500 >= a ? 205 - .28 * (a - 250) : 134 + .21 * (a - 500)
        },
        "text-only": function (a) {
            return 500 >= a ? 187 - .228 * (a - 250) : 130
        },
        "in-article": function (a) {
            return 420 >= a ? a / 1.2 : 460 >= a ? a / 1.91 + 130 : 800 >= a ? a / 4 : 200
        }
    };

    function Lg(a, b) {
        L.call(this, a, b)
    }
    ja(Lg, L);
    Lg.prototype.G = function () {
        return Math.min(1200, this.minWidth())
    };

    function Mg(a, b, c, d, e) {
        var f = e.google_ad_layout || "image-top";
        if ("in-article" == f && "false" != e.google_full_width_responsive) {
            var g = Ge(b, c, a, .2, e);
            if (!0 !== g) e.gfwrnwer = g;
            else if (g = K(b)) {
                e.google_full_width_responsive_allowed = !0;
                var h = c.parentElement;
                if (h) {
                    b: for (var k = c, n = 0; 100 > n && k.parentElement; ++n) {
                        for (var m = k.parentElement.childNodes, p = 0; p < m.length; ++p) {
                            var t = m[p];
                            if (t != k && Ie(b, t)) break b
                        }
                        k = k.parentElement;
                        k.style.width = "100%";
                        k.style.height = "auto"
                    }
                    Je(b, c, h, a, g, e); a = g
                }
            }
        }
        if (250 > a) throw new I("Fluid responsive ads must be at least 250px wide: availableWidth=" + a);
        b = Math.min(1200, Math.floor(a));
        if (d && "in-article" != f) {
            f = Math.ceil(d);
            if (50 > f) throw new I("Fluid responsive ads must be at least 50px tall: height=" + f);
            return new pg(11, new L(b, f))
        }
        if ("in-article" != f && (d = e.google_ad_layout_key)) {
            f = "" + d;
            d = Math.pow(10, 3);
            if (c = (e = f.match(/([+-][0-9a-z]+)/g)) && e.length) {
                a = [];
                for (g = 0; g < c; g++) a.push(parseInt(e[g], 36) / d);
                d = a
            } else d = null;
            if (!d) throw new I("Invalid data-ad-layout-key value: " + f);
            f = (b + -725) / 1E3;
            e = 0;
            c = 1;
            a = d.length;
            for (g = 0; g < a; g++) e += d[g] * c, c *= f;
            f = Math.ceil(1E3 * e - -725 + 10);
            if (isNaN(f)) throw new I("Invalid height: height=" + f);
            if (50 > f) throw new I("Fluid responsive ads must be at least 50px tall: height=" + f);
            if (1200 < f) throw new I("Fluid responsive ads must be at most 1200px tall: height=" + f);
            return new pg(11, new L(b, f))
        }
        d = Kg[f];
        if (!d) throw new I("Invalid data-ad-layout value: " + f);
        d = Math.ceil(d(b));
        return new pg(11, "in-article" == f ? new Lg(b, d) : new L(b, d))
    };

    function Ng(a, b) {
        L.call(this, a, b)
    }
    ja(Ng, L);
    Ng.prototype.G = function () {
        return this.minWidth()
    };
    Ng.prototype.V = function (a) {
        return L.prototype.V.call(this, a) + "_0ads_al"
    };
    var Og = [new Ng(728, 15), new Ng(468, 15), new Ng(200, 90), new Ng(180, 90), new Ng(160, 90), new Ng(120, 90)];

    function Pg(a, b, c) {
        var d = 250,
            e = 90;
        d = void 0 === d ? 130 : d;
        e = void 0 === e ? 30 : e;
        var f = zg(Og, Ke(a));
        if (!f) throw new I("No link unit size for width=" + a + "px");
        a = Math.min(a, 1200);
        f = f.height();
        b = Math.max(f, b);
        d = (new pg(10, new Ng(a, Math.min(b, 15 == f ? e : d)))).a;
        b = d.minWidth();
        d = d.height();
        15 <= c && (d = c);
        return new pg(10, new Ng(b, d))
    }

    function Qg(a, b, c, d) {
        if ("false" == d.google_full_width_responsive) return d.google_full_width_responsive_allowed = !1, d.gfwrnwer = 1, a;
        var e = He(a, b, c, d);
        if (!0 !== e) return d.google_full_width_responsive_allowed = !1, d.gfwrnwer = e, a;
        e = K(b);
        if (!e) return a;
        d.google_full_width_responsive_allowed = !0;
        Je(b, c, c.parentElement, a, e, d);
        return e
    };

    function Rg(a, b, c, d, e) {
        var f;
        (f = K(b)) ? 488 > K(b) ? b.innerHeight >= b.innerWidth ? (e.google_full_width_responsive_allowed = !0, Je(b, c, c.parentElement, a, f, e), f = {
            j: f,
            l: !0
        }) : f = {
            j: a,
            l: 5
        } : f = {
            j: a,
            l: 4
        } : f = {
            j: a,
            l: 10
        };
        var g = f;
        f = g.j;
        g = g.l;
        if (!0 !== g || a == f) return new pg(12, new L(a, d), null, !0, g, 100);
        a = Fg(f, "auto", b, c, e, !0);
        return new pg(12, a.C, a.Z, !0, g, a.B, a.w, a.A)
    };

    function Sg(a) {
        var b = a.google_ad_format;
        if ("autorelaxed" == b) {
            a: {
                if ("pedestal" != a.google_content_recommendation_ui_type) {
                    var c;
                    (b = "undefined" != typeof Symbol && Symbol.iterator && ba[Symbol.iterator]) ? c = b.call(ba) : c = {
                        next: aa()
                    };
                    for (b = c.next() ; !b.done; b = c.next())
                        if (null != a[b.value]) {
                            a = !0;
                            break a
                        }
                }
                a = !1
            }
            return a ? 9 : 5
        }
        if (Dg(b)) return 1;
        if ("link" == b) return 4;
        if ("fluid" == b) return 8
    }

    function Tg(a, b, c, d, e) {
        e = b.offsetWidth || (c.google_ad_resize || (void 0 === e ? !1 : e)) && M(b, d, "width", D) || c.google_ad_width || 0;
        var f = F(d, Xd.f) && 4 === a,
            g = F(d, Zd.f) && (5 === a || 9 === a);
        if (f || g) c.google_ad_format = "auto", c.google_ad_slot = "", a = 1;
        f = (f = Ug(a, e, b, c, d)) ? f : Eg(e, c.google_ad_format, d, b, c);
        f.a.P(d, e, c, b);
        qg(f, e, c);
        1 != a && (a = f.a.height(), b.style.height = a + "px")
    }

    function Ug(a, b, c, d, e) {
        var f = d.google_ad_height || M(c, e, "height", D);
        switch (a) {
            case 5:
                return a = ud(247, wd, function () {
                    return Cg(b, d.google_ad_format, e, c, d)
                }), f = a.j, a = a.l, !0 === a && b != f && Je(e, c, c.parentElement, b, f, d), !0 === a ? d.google_full_width_responsive_allowed = !0 : (d.google_full_width_responsive_allowed = !1, d.gfwrnwer = a), sg(f, d);
            case 9:
                return wg(b, d);
            case 4:
                return a = Qg(b, e, c, d), Pg(a, Qe(e, c), f);
            case 8:
                return Mg(b, e, c, f, d);
            case 10:
                return Rg(b, e, c, f, d)
        }
    };

    function U(a) {
        this.h = [];
        this.b = a || window;
        this.a = 0;
        this.g = null;
        this.i = 0
    }
    var Vg;
    l = U.prototype;
    l.Ga = function (a, b) {
        0 != this.a || 0 != this.h.length || b && b != window ? this.ha(a, b) : (this.a = 2, this.sa(new Wg(a, window)))
    };
    l.ha = function (a, b) {
        this.h.push(new Wg(a, b || this.b));
        Xg(this)
    };
    l.Oa = function (a) {
        this.a = 1;
        if (a) {
            var b = vd(188, za(this.ra, this, !0));
            this.g = this.b.setTimeout(b, a)
        }
    };
    l.ra = function (a) {
        a && ++this.i;
        1 == this.a && (null != this.g && (this.b.clearTimeout(this.g), this.g = null), this.a = 0);
        Xg(this)
    };
    l.Ua = function () {
        return !(!window || !Array)
    };
    l.Ia = function () {
        return this.i
    };

    function Xg(a) {
        var b = vd(189, za(a.Wa, a));
        a.b.setTimeout(b, 0)
    }
    l.Wa = function () {
        if (0 == this.a && this.h.length) {
            var a = this.h.shift();
            this.a = 2;
            var b = vd(190, za(this.sa, this, a));
            a.a.setTimeout(b, 0);
            Xg(this)
        }
    };
    l.sa = function (a) {
        this.a = 0;
        a.b()
    };

    function Yg(a) {
        try {
            return a.sz()
        } catch (b) {
            return !1
        }
    }

    function Zg(a) {
        return !!a && ("object" === typeof a || "function" === typeof a) && Yg(a) && lc(a.nq) && lc(a.nqa) && lc(a.al) && lc(a.rl)
    }

    function $g() {
        if (Vg && Yg(Vg)) return Vg;
        var a = Od(),
            b = a.google_jobrunner;
        return Zg(b) ? Vg = b : a.google_jobrunner = Vg = new U(a)
    }

    function ah(a, b) {
        $g().nq(a, b)
    }

    function bh(a, b) {
        $g().nqa(a, b)
    }
    U.prototype.nq = U.prototype.Ga;
    U.prototype.nqa = U.prototype.ha;
    U.prototype.al = U.prototype.Oa;
    U.prototype.rl = U.prototype.ra;
    U.prototype.sz = U.prototype.Ua;
    U.prototype.tc = U.prototype.Ia;

    function Wg(a, b) {
        this.b = a;
        this.a = b
    };

    function ch(a, b) {
        var c = tc(b);
        if (c) {
            c = K(c);
            var d = Hb(a, b) || {},
                e = d.direction;
            if ("0px" === d.width && "none" != d.cssFloat) return -1;
            if ("ltr" === e && c) return Math.floor(Math.min(1200, c - a.getBoundingClientRect().left));
            if ("rtl" === e && c) return a = b.document.body.getBoundingClientRect().right - a.getBoundingClientRect().right, Math.floor(Math.min(1200, c - a - Math.floor((c - b.document.body.clientWidth) / 2)))
        }
        return -1
    };

    function dh(a) {
        var b = this;
        this.a = a;
        a.google_iframe_oncopy || (a.google_iframe_oncopy = {
            handlers: {},
            upd: function (a, d) {
                var c = eh("rx", a),
                    f = Number;
                a: {
                    if (a && (a = a.match("dt=([^&]+)")) && 2 == a.length) {
                        a = a[1];
                        break a
                    }
                    a = ""
                }
                f = f(a);
                f = (new Date).getTime() - f;
                c = c.replace(/&dtd=(\d+|-?M)/, "&dtd=" + (1E5 <= f ? "M" : 0 <= f ? f : "-M"));
                b.set(d, c);
                return c
            }
        });
        this.b = a.google_iframe_oncopy
    }
    dh.prototype.set = function (a, b) {
        var c = this;
        this.b.handlers[a] = b;
        this.a.addEventListener && this.a.addEventListener("load", function () {
            var b = c.a.document.getElementById(a);
            try {
                var e = b.contentWindow.document;
                if (b.onload && e && (!e.body || !e.body.firstChild)) b.onload()
            } catch (f) { }
        }, !1)
    };

    function eh(a, b) {
        var c = new RegExp("\\b" + a + "=(\\d+)"),
            d = c.exec(b);
        d && (b = b.replace(c, a + "=" + (+d[1] + 1 || 1)));
        return b
    }
    var fh, gh = "var i=this.id,s=window.google_iframe_oncopy,H=s&&s.handlers,h=H&&H[i],w=this.contentWindow,d;try{d=w.document}catch(e){}if(h&&d&&(!d.body||!d.body.firstChild)){if(h.call){setTimeout(h,0)}else if(h.match){try{h=s.upd(h,i)}catch(e){}w.location.replace(h)}}";
    var V = gh;
    /[\x00&<>"']/.test(V) && (-1 != V.indexOf("&") && (V = V.replace(Ia, "&amp;")), -1 != V.indexOf("<") && (V = V.replace(Ja, "&lt;")), -1 != V.indexOf(">") && (V = V.replace(Ka, "&gt;")), -1 != V.indexOf('"') && (V = V.replace(La, "&quot;")), -1 != V.indexOf("'") && (V = V.replace(Ma, "&#39;")), -1 != V.indexOf("\x00") && (V = V.replace(Na, "&#0;")));
    gh = V;
    fh = gh;
    var hh = {},
        ih = (hh.google_ad_modifications = !0, hh.google_analytics_domain_name = !0, hh.google_analytics_uacct = !0, hh.google_pause_ad_requests = !0, hh);

    function jh() {
        var a = q;
        this.b = a = void 0 === a ? q : a;
        this.i = "https://securepubads.g.doubleclick.net/static/3p_cookie.html";
        this.a = 2;
        this.g = [];
        this.h = !1;
        a: {
            a = Fb(!1, 50);
            var b = Db(q);
            b && a.unshift(b);
            a.unshift(q);
            var c;
            for (b = 0; b < a.length; ++b) try {
                var d = a[b],
                    e = kh(d);
                if (e) {
                    this.a = lh(e);
                    if (2 != this.a) break a;
                    !c && C(d) && (c = d)
                }
            } catch (f) { }
            this.b = c || this.b
        }
    }

    function mh(a) {
        if (2 != nh(a)) {
            for (var b = 1 == nh(a), c = 0; c < a.g.length; c++) try {
                a.g[c](b)
            } catch (d) { }
            a.g = []
        }
    }

    function oh(a) {
        var b = kh(a.b);
        b && 2 == a.a && (a.a = lh(b))
    }

    function nh(a) {
        oh(a);
        return a.a
    }

    function ph(a) {
        var b = qh;
        b.g.push(a);
        if (2 != b.a) mh(b);
        else if (b.h || (Yb(b.b, "message", function (a) {
                var c = kh(b.b);
                if (c && a.source == c && 2 == b.a) {
                    switch (a.data) {
                        case "3p_cookie_yes":
                            b.a = 1;
                            break;
                        case "3p_cookie_no":
                            b.a = 0
        }
                    mh(b)
        }
        }), b.h = !0), kh(b.b)) mh(b);
        else {
            a = yb(new xb(b.b.document), "IFRAME");
            a.src = b.i;
            a.name = "detect_3p_cookie";
            a.style.visibility = "hidden";
            a.style.display = "none";
            a.onload = function () {
                oh(b);
                mh(b)
            };
            try {
                b.b.document.body.appendChild(a)
            } catch (c) { }
        }
    }

    function kh(a) {
        return a.frames && a.frames[Wa("detect_3p_cookie")] || null
    }

    function lh(a) {
        return Sb(a, "3p_cookie_yes") ? 1 : Sb(a, "3p_cookie_no") ? 0 : 2
    };
    var rh = /^\.google\.(com?\.)?[a-z]{2,3}$/,
        sh = /\.(cn|com\.bi|do|sl|ba|by|ma|am)$/;

    function th(a) {
        return rh.test(a) && !sh.test(a)
    }
    var uh = q,
        qh;

    function vh(a) {
        a = "https://" + ("adservice" + a + "/adsid/integrator.js");
        var b = ["domain=" + encodeURIComponent(q.location.hostname)];
        W[3] >= +new Date && b.push("adsid=" + encodeURIComponent(W[1]));
        return a + "?" + b.join("&")
    }
    var W, X;

    function wh() {
        uh = q;
        W = uh.googleToken = uh.googleToken || {};
        var a = +new Date;
        W[1] && W[3] > a && 0 < W[2] || (W[1] = "", W[2] = -1, W[3] = -1, W[4] = "", W[6] = "");
        X = uh.googleIMState = uh.googleIMState || {};
        th(X[1]) || (X[1] = ".google.com");
        "array" == ua(X[5]) || (X[5] = []);
        "boolean" == typeof X[6] || (X[6] = !1);
        "array" == ua(X[7]) || (X[7] = []);
        oa(X[8]) || (X[8] = 0)
    }
    var Z = {
        W: function () {
            return 0 < X[8]
        },
        Qa: function () {
            X[8]++
        },
        Ra: function () {
            0 < X[8] && X[8]--
        },
        Sa: function () {
            X[8] = 0
        },
        $a: function () {
            return !1
        },
        ia: function () {
            return X[5]
        },
        fa: function (a) {
            try {
                a()
            } catch (b) {
                q.setTimeout(function () {
                    throw b;
                }, 0)
            }
        },
        qa: function () {
            if (!Z.W()) {
                var a = q.document,
                    b = function (b) {
                        b = vh(b);
                        a: {
                            try {
                                var c = pa();
                                break a
                            } catch (g) { }
                            c = void 0
                        }
                        zf(a, b, c);
                        c = a.createElement("script");
                        c.type = "text/javascript";
                        c.onerror = function () {
                            return q.processGoogleToken({}, 2)
                        };
                        b = zb(b);
                        wb(c, b);
                        try {
                            (a.head || a.body || a.documentElement).appendChild(c), Z.Qa()
                        } catch (g) { }
                    },
                    c = X[1];
                b(c);
                ".google.com" != c && b(".google.com");
                b = {};
                var d = (b.newToken = "FBT", b);
                q.setTimeout(function () {
                    return q.processGoogleToken(d, 1)
                }, 1E3)
            }
        }
    };

    function xh(a) {
        wh();
        var b = uh.googleToken[5] || 0;
        a && (0 != b || W[3] >= +new Date ? Z.fa(a) : (Z.ia().push(a), Z.qa()));
        W[3] >= +new Date && W[2] >= +new Date || Z.qa()
    }

    function yh(a) {
        q.processGoogleToken = q.processGoogleToken || function (a, c) {
            var b = a;
            b = void 0 === b ? {} : b;
            c = void 0 === c ? 0 : c;
            a = b.newToken || "";
            var e = "NT" == a,
                f = parseInt(b.freshLifetimeSecs || "", 10),
                g = parseInt(b.validLifetimeSecs || "", 10),
                h = b["1p_jar"] || "";
            b = b.pucrd || "";
            wh();
            1 == c ? Z.Sa() : Z.Ra();
            var k = uh.googleToken = uh.googleToken || {},
                n = 0 == c && a && r(a) && !e && oa(f) && 0 < f && oa(g) && 0 < g && r(h);
            e = e && !Z.W() && (!(W[3] >= +new Date) || "NT" == W[1]);
            var m = !(W[3] >= +new Date) && 0 != c;
            if (n || e || m) e = +new Date, f = e + 1E3 * f, g = e + 1E3 * g, 1E-5 > Math.random() && Zb("https://pagead2.googlesyndication.com/pagead/gen_204?id=imerr&err=" + c, null), k[5] = c, k[1] = a, k[2] = f, k[3] = g, k[4] = h, k[6] = b, wh();
            if (n || !Z.W()) {
                c = Z.ia();
                for (a = 0; a < c.length; a++) Z.fa(c[a]);
                c.length = 0
            }
        };
        xh(a)
    }

    function zh(a) {
        qh = qh || new jh;
        ph(function (b) {
            b && a()
        })
    };
    var Ah = Wa("script");

    function Bh() {
        B.google_sa_impl && !B.document.getElementById("google_shimpl") && (B.google_sa_queue = null, B.google_sl_win = null, B.google_sa_impl = null);
        if (!B.google_sa_queue) {
            B.google_sa_queue = [];
            B.google_sl_win = B;
            B.google_process_slots = function () {
                return Ch(B)
            };
            var a = Dh();
            zf(B.document, a);
            !v(w, "Chrome") && !v(w, "CriOS") || v(w, "Edge") ? Gb(B.document, a).id = "google_shimpl" : (a = document.createElement("IFRAME"), a.id = "google_shimpl", a.style.display = "none", B.document.documentElement.appendChild(a), dg(B, "google_shimpl", "<!doctype html><html><body>" + ("<" + Ah + ">") + "google_sl_win=window.parent;google_async_iframe_id='google_shimpl';" + ("</" + Ah + ">") + ["<", Ah, ' src="', Dh("/show_ads_impl.js"), '"></', Ah, ">"].join("") + "</body></html>"), a.contentWindow.document.close())
        }
    }
    var Ch = vd(215, function (a) {
        var b = a.google_sa_queue,
            c = b.shift();
        a.google_sa_impl || xd("shimpl", {
            t: "no_fn"
        });
        "function" == ua(c) && ud(216, wd, c);
        b.length && a.setTimeout(function () {
            return Ch(a)
        }, 0)
    });

    function Eh(a, b, c) {
        a.google_sa_queue = a.google_sa_queue || [];
        a.google_sa_impl ? c(b) : a.google_sa_queue.push(b)
    }

    function Dh(a) {
        a = void 0 === a ? "/show_ads_impl.js" : a;
        var b = fc ? "https" : "http";
        a: {
            if (dc) try {
                var c = B.google_cafe_host || B.top.google_cafe_host;
                if (c) {
                    var d = c;
                    break a
                }
            } catch (e) { }
            d = hc()
        }
        return Id(d, ["/pagead/js/", cc(), "/r20190131", a, ""].join(""), b)
    }

    function Fh(a, b, c, d) {
        return function () {
            var e = !1;
            d && $g().al(3E4);
            try {
                dg(a, b, c), e = !0
            } catch (g) {
                var f = Od().google_jobrunner;
                Zg(f) && f.rl()
            }
            e && (e = eh("google_async_rrc", c), (new dh(a)).set(b, Fh(a, b, e, !1)))
        }
    }

    function Gh(a) {
        if (!eg) a: {
            for (var b = Fb(), c = 0; c < b.length; c++) try {
                var d = b[c].frames.google_esf;
                if (d) {
                    eg = d;
                    break a
                }
            } catch (e) { }
            eg = null
        }
        if (!eg) {
            if (/[^a-z0-9-]/.test(a)) return null;
            b = document.createElement("IFRAME");
            b.id = "google_esf";
            b.name = "google_esf";
            c = Id(bc("", "googleads.g.doubleclick.net"), ["/pagead/html/", cc(), "/r20190131/zrt_lookup.html#", encodeURIComponent("")].join(""));
            b.src = c;
            b.style.display = "none";
            b.setAttribute("data-ad-client", pf(a));
            return b
        }
        return null
    }

    function Hh(a, b, c) {
        Ih(a, b, c, function (a, b, f) {
            a = a.document;
            for (var d = b.id, e = 0; !d || a.getElementById(d + "_anchor") ;) d = "aswift_" + e++;
            b.id = d;
            b.name = d;
            d = Number(f.google_ad_width || 0);
            e = Number(f.google_ad_height || 0);
            var k = f.ds || "";
            k && (k += k.endsWith(";") ? "" : ";");
            var n = "";
            if (!f.google_enable_single_iframe) {
                n = ["<iframe"];
                for (m in b) b.hasOwnProperty(m) && n.push(m + "=" + b[m]);
                n.push('style="' + ("left:0;position:absolute;top:0;border:0px;" + ("width:" + d + "px;") + ("height:" + e + "px;")) + '"');
                n.push("></iframe>");
                n = n.join(" ")
            }
            var m = b.id;
            var p = "";
            p = void 0 === p ? "" : p;
            d = "border:none;height:" + e + "px;margin:0;padding:0;" + ("position:relative;visibility:visible;width:" + d + "px;") + "background-color:transparent;";
            m = ['<ins id="' + (m + "_expand") + '"', ' style="display:inline-table;' + d + (void 0 === k ? "" : k) + '"', p ? ' data-ad-slot="' + p + '">' : ">", '<ins id="' + (m + "_anchor") + '" style="display:block;' + d + '">', n, "</ins></ins>"].join("");
            16 == f.google_reactive_ad_format ? (f = a.createElement("div"), f.innerHTML = m, c.appendChild(f.firstChild)) : c.innerHTML = m;
            return b.id
        })
    }

    function Ih(a, b, c, d) {
        var e = b.google_ad_width,
            f = b.google_ad_height;
        F(a, pe.f) && (b.google_enable_single_iframe = !0);
        var g = {};
        null != e && (g.width = e && '"' + e + '"');
        null != f && (g.height = f && '"' + f + '"');
        g.frameborder = '"0"';
        g.marginwidth = '"0"';
        g.marginheight = '"0"';
        g.vspace = '"0"';
        g.hspace = '"0"';
        g.allowtransparency = '"true"';
        g.scrolling = '"no"';
        g.allowfullscreen = '"true"';
        g.onload = '"' + fh + '"';
        d = d(a, g, b);
        Jh(a, c, b);
        (c = Gh(b.google_ad_client)) && a.document.documentElement.appendChild(c);
        c = Ba;
        e = (new Date).getTime();
        b.google_lrv = cc();
        b.google_async_iframe_id = d;
        b.google_unique_id = nc(a);
        b.google_start_time = c;
        b.google_bpp = e > c ? e - c : 1;
        b.google_async_rrc = 0;
        a.google_sv_map = a.google_sv_map || {};
        a.google_sv_map[d] = b;
        a.google_t12n_vars = vf;
        if (b.google_enable_single_iframe) {
            var h = {
                pubWin: a,
                iframeWin: null,
                vars: b
            };
            Eh(a, function () {
                a.google_sa_impl(h)
            }, a.document.getElementById(d + "_anchor") ? ah : bh)
        } else Eh(a, Fh(a, d, ["<!doctype html><html><body>", "<" + Ah + ">", "google_sl_win=window.parent;google_iframe_start_time=new Date().getTime();", 'google_async_iframe_id="' + d + '";', "</" + Ah + ">", "<" + Ah + ">window.parent.google_sa_impl(" + ("{iframeWin: window, pubWin: window.parent, vars: " + ("window.parent['google_sv_map']['" + d + "']") + "}") + ");</" + Ah + ">", "</body></html>"].join(""), !0), a.document.getElementById(d) ? ah : bh)
    }

    function Jh(a, b, c) {
        var d = c.google_ad_output,
            e = c.google_ad_format,
            f = c.google_ad_width || 0,
            g = c.google_ad_height || 0;
        e || "html" != d && null != d || (e = f + "x" + g);
        d = !c.google_ad_slot || c.google_override_format || !jb[c.google_ad_width + "x" + c.google_ad_height] && "aa" == c.google_loader_used;
        e && d ? e = e.toLowerCase() : e = "";
        c.google_ad_format = e;
        if (!oa(c.google_reactive_sra_index) || !c.google_ad_unit_key) {
            e = [c.google_ad_slot, c.google_orig_ad_format || c.google_ad_format, c.google_ad_type, c.google_orig_ad_width || c.google_ad_width, c.google_orig_ad_height || c.google_ad_height];
            d = [];
            f = 0;
            for (g = b; g && 25 > f; g = g.parentNode, ++f) 9 === g.nodeType ? d.push("") : d.push(g.id);
            (d = d.join()) && e.push(d);
            c.google_ad_unit_key = Nb(e.join(":")).toString();
            var h = void 0 === h ? !1 : h;
            e = [];
            for (d = 0; b && 25 > d; ++d) {
                f = "";
                void 0 !== h && h || (f = (f = 9 !== b.nodeType && b.id) ? "/" + f : "");
                a: {
                    if (b && b.nodeName && b.parentElement) {
                        g = b.nodeName.toString().toLowerCase();
                        for (var k = b.parentElement.childNodes, n = 0, m = 0; m < k.length; ++m) {
                            var p = k[m];
                            if (p.nodeName && p.nodeName.toString().toLowerCase() === g) {
                                if (b === p) {
                                    g = "." + n;
                                    break a
                                } ++n
                            }
                        }
                    }
                    g = ""
                }
                e.push((b.nodeName && b.nodeName.toString().toLowerCase()) + f + g);
                b = b.parentElement
            }
            h = e.join() + ":";
            b = [];
            if (a) try {
                var t = a.parent;
                for (e = 0; t && t !== a && 25 > e; ++e) {
                    var y = t.frames;
                    for (d = 0; d < y.length; ++d)
                        if (a === y[d]) {
                            b.push(d);
                            break
                        }
                    a = t;
                    t = a.parent
                }
            } catch (Ga) { }
            c.google_ad_dom_fingerprint = Nb(h + b.join()).toString()
        }
    }

    function Kh(a, b) {
        var c = navigator;
        a && b && c && (a = a.document, b = pf(b), /[^a-z0-9-]/.test(b) || ((c = Ha("r20160913")) && (c += "/"), Gb(a, Id("pagead2.googlesyndication.com", "/pub-config/" + c + b + ".js"))))
    };

    function Lh(a, b) {
        a = a.attributes;
        for (var c = a.length, d = 0; d < c; d++) {
            var e = a[d];
            if (/data-/.test(e.name)) {
                var f = Ha(e.name.replace("data-matched-content", "google_content_recommendation").replace("data", "google").replace(/-/g, "_"));
                if (!b.hasOwnProperty(f)) {
                    e = e.value;
                    var g = {};
                    g = (g.google_reactive_ad_format = $b, g.google_allow_expandable_ads = Rb, g);
                    e = g.hasOwnProperty(f) ? g[f](e, null) : e;
                    null === e || (b[f] = e)
                }
            }
        }
    }

    function Mh(a) {
        if (a = ic(a)) switch (a.data && a.data.autoFormat) {
            case "rspv":
                return 13;
            case "mcrspv":
                return 15;
            default:
                return 14
        } else return 12
    }

    function Nh(a, b, c) {
        Lh(a, b);
        if (c.document && c.document.body && !Sg(b) && !b.google_reactive_ad_format) {
            var d = parseInt(a.style.width, 10),
                e = ch(a, c);
            if (0 < e && d > e) {
                var f = parseInt(a.style.height, 10);
                d = !!jb[d + "x" + f];
                var g = e;
                if (d) {
                    var h = kb(e, f);
                    if (h) g = h, b.google_ad_format = h + "x" + f + "_0ads_al";
                    else throw Error("TSS=" + e);
                }
                b.google_ad_resize = !0;
                b.google_ad_width = g;
                d || (b.google_ad_format = null, b.google_override_format = !0);
                e = g;
                a.style.width = e + "px";
                f = Eg(e, "auto", c, a, b);
                g = e;
                f.a.P(c, g, b, a);
                qg(f, g, b);
                f = f.a;
                b.google_responsive_formats = null;
                f.minWidth() > e && !d && (b.google_ad_width = f.minWidth(), a.style.width = f.minWidth() + "px")
            }
        }
        d = b.google_reactive_ad_format;
        if (!b.google_enable_content_recommendations || 1 != d && 2 != d) {
            d = a.offsetWidth || M(a, c, "width", D) || b.google_ad_width || 0;
            a: {
                e = Aa(Eg, d, "auto", c, a, b, !1, !0);
                h = F(c, J.c);
                var k = F(c, J.f);
                f = F(c, ie.c);
                g = F(c, ie.f);
                var n = sf(c, 11, b.google_ad_client),
                    m = F(c, ke.f);
                var p = b.google_ad_client;
                p = null != qf(c, void 0 === p ? "" : p);
                if (!(h || k || n || p) || !Bb() || b.google_reactive_ad_format || Sg(b) || Ce(a, b) || b.google_ad_resize || sc(c) != c) d = !1;
                else {
                    for (k = a; k; k = k.parentElement)
                        if (n = Hb(k, c), (p = !n) || (p = !(0 <= Ca(["static", "relative"], n.position))), p) {
                            d = !1;
                            break a
                        }
                    if (!0 !== Ge(c, a, d, .3, b)) d = !1;
                    else {
                        b.google_resizing_allowed = !0;
                        k = nf(c.location, "google_responsive_slot_debug") || nf(c.location, "google_responsive_slot_preview") || cg(c, J.c, J.f, ie.c, ie.f);
                        n = O(yf(), 142);
                        if (k || Math.random() < n) b.ovlp = !0;
                        h || g || m ? (h = {}, qg(e(), d, h), b.google_resizing_width = h.google_ad_width, b.google_resizing_height = h.google_ad_height, h.ds && (b.ds = h.ds), b.iaaso = !1) : (b.google_ad_format = "auto", b.iaaso = !0);
                        (d = f ? "AutoOptimizeAdSizeVariant" : g ? "AutoOptimizeAdSizeOriginal" : null) && (b.google_ad_channel = b.google_ad_channel ? [b.google_ad_channel, d].join("+") : d);
                        d = !0
                    }
                }
            }
            if (e = Sg(b)) Tg(e, a, b, c, d);
            else {
                if (Ce(a, b)) {
                    if (d = Hb(a, c)) a.style.width = d.width, a.style.height = d.height, Be(d, b);
                    b.google_ad_width || (b.google_ad_width = a.offsetWidth);
                    b.google_ad_height || (b.google_ad_height = a.offsetHeight);
                    b.google_loader_features_used = 256;
                    b.google_responsive_auto_format = Mh(c)
                } else Be(a.style, b), 300 == b.google_ad_width && 250 == b.google_ad_height && (d = a.style.width, a.style.width = "100%", e = a.offsetWidth, a.style.width = d, b.google_available_width = e);
                c.location && "#gfwmrp" == c.location.hash || 12 == b.google_responsive_auto_format && "true" == b.google_full_width_responsive && !F(c, Td.f) ? Tg(10, a, b, c, !1) : F(c, Ud.f) && 12 == b.google_responsive_auto_format && (a = He(a.offsetWidth || parseInt(a.style.width, 10) || b.google_ad_width, c, a, b), !0 !== a ? (b.efwr = !1, b.gfwrnwer = a) : b.efwr = !0)
            }
        } else b.google_ad_width = K(c), b.google_ad_height = 50, a.style.display = "none"
    };

    function Oh(a) {
        return rc.test(a.className) && "done" != a.getAttribute("data-adsbygoogle-status")
    }

    function Ph(a, b) {
        var c = window;
        a.setAttribute("data-adsbygoogle-status", "done");
        Qh(a, b, c)
    }

    function Qh(a, b, c) {
        var d = qc();
        d.google_spfd || (d.google_spfd = Nh);
        (d = b.google_reactive_ads_config) || Nh(a, b, c);
        if (!Rh(a, b, c)) {
            d || (c.google_lpabyc = Bf(c, a));
            if (d) {
                if (E(B).page_contains_reactive_tag) {
                    if (d.page_level_pubvars && d.page_level_pubvars.pltais) return;
                    throw new I("Only one 'enable_page_level_ads' allowed per page.");
                }
                E(B).page_contains_reactive_tag = !0
            } else mc(c);
            E(B).per_pub_js_loaded || (E(B).per_pub_js_loaded = !0, Kh(c, b.google_ad_client));
            kc(ih, function (a, d) {
                b[d] = b[d] || c[d]
            });
            b.google_loader_used = "aa";
            b.google_reactive_tag_first = 1 === (E(B).first_tag_on_page || 0);
            ud(164, wd, function () {
                Hh(c, b, a)
            })
        }
    }

    function Rh(a, b, c) {
        var d = b.google_reactive_ads_config;
        if (d) {
            var e = d.page_level_pubvars;
            e = (wa(e) ? e : {}).google_tag_origin
        }
        var f = e || b.google_tag_origin;
        e = r(a.className) && /(\W|^)adsbygoogle-noablate(\W|$)/.test(a.className);
        var g = c.google_bfabyc;
        c.google_pbfabyc && !b.ebfa ? b.ebfaca = !0 : g && !b.google_bfa && (b.ebfaca = !0);
        var h = b.google_ad_slot;
        g = E(c);
        vc(g.ad_whitelist || [], h, f) ? g = null : (f = g.space_collapsing || "none", g = (h = vc(g.ad_blacklist || [], h)) ? {
            da: !0,
            ua: h.space_collapsing || f
        } : g.remove_ads_by_default ? {
            da: !0,
            ua: f,
            Fa: g.dont_remove_atf
        } : null);
        if (e = g && g.da && "on" != b.google_adtest && !e) {
            a: {
                try {
                    if (a.parentNode && 0 < a.offsetWidth && 0 < a.offsetHeight && a.style && "none" !== a.style.display && "hidden" !== a.style.visibility && (!a.style.opacity || 0 !== Number(a.style.opacity))) {
                        var k = a.getBoundingClientRect();
                        var n = 0 < k.right && 0 < k.bottom;
                        break a
                    }
                } catch (m) { }
                n = !1
            }
            n && (n = De(a, c) < te(c).clientHeight); e = !(n && g.Fa)
        }
        if (e) return a.className += " adsbygoogle-ablated-ad-slot", c = c.google_sv_map = c.google_sv_map || {}, b.google_ad_slot && (c[b.google_ad_slot] = b, a.setAttribute("google_ad_slot", b.google_ad_slot)), "slot" == g.ua && (null !== Qb(a.getAttribute("width")) && a.setAttribute("width", 0), null !== Qb(a.getAttribute("height")) && a.setAttribute("height", 0), a.style.width = "0px", a.style.height = "0px"), !0;
        if ((n = Hb(a, c)) && "none" == n.display && !("on" == b.google_adtest || 0 < b.google_reactive_ad_format || d)) return c.document.createComment && a.appendChild(c.document.createComment("No ad requested because of display:none on the adsbygoogle tag")), !0;
        a = null == b.google_pgb_reactive || 3 === b.google_pgb_reactive;
        return 1 !== b.google_reactive_ad_format && 8 !== b.google_reactive_ad_format || !a ? !1 : (q.console && q.console.warn("Adsbygoogle tag with data-reactive-ad-format=" + b.google_reactive_ad_format + " is deprecated. Check out page-level ads at https://www.google.com/adsense"), !0)
    }

    function Sh(a) {
        var b = document.getElementsByTagName("INS");
        for (var c = 0, d = b[c]; c < b.length; d = b[++c]) {
            var e = d;
            if (Oh(e) && "reserved" != e.getAttribute("data-adsbygoogle-status") && (!a || d.id == a)) return d
        }
        return null
    }

    function Th() {
        var a = document.createElement("INS");
        a.className = "adsbygoogle";
        a.className += " adsbygoogle-noablate";
        Tb(a);
        return a
    }

    function Uh(a) {
        var b = {};
        kc(wc, function (c, d) {
            !1 === a.enable_page_level_ads ? b[d] = !1 : a.hasOwnProperty(d) && (b[d] = a[d])
        });
        wa(a.enable_page_level_ads) && (b.page_level_pubvars = a.enable_page_level_ads);
        var c = Th();
        ib.body.appendChild(c);
        var d = {};
        d = (d.google_reactive_ads_config = b, d.google_ad_client = a.google_ad_client, d);
        d.google_pause_ad_requests = E(B).pause_ad_requests || !1;
        Ph(c, d)
    }

    function Vh(a) {
        function b() {
            return Uh(a)
        }
        var c = void 0 === c ? ib : c;
        var d = tc(window);
        if (!d) throw new I("Page-level tag does not work inside iframes.");
        se(d).wasPlaTagProcessed = !0;
        if (c.body || "complete" == c.readyState || "interactive" == c.readyState) b();
        else {
            var e = ob(nd(191, b));
            Yb(c, "DOMContentLoaded", e);
            kc(E(B).eids || [], function (a) {
                switch (a) {
                    case qe.T:
                        var b = q.setInterval(function () {
                            c.body && (e(), q.clearInterval(b))
                        }, 100);
                        break;
                    case qe.R:
                        q.MutationObserver && (new q.MutationObserver(function (a, b) {
                            c.body && (e(), b.disconnect())
                        })).observe(c, {
                            childList: !0,
                            subtree: !0
                        })
                }
            })
        }
    }

    function Wh(a) {
        var b = {};
        ud(165, yd, function () {
            Xh(a, b)
        }, function (c) {
            c.client = c.client || b.google_ad_client || a.google_ad_client;
            c.slotname = c.slotname || b.google_ad_slot;
            c.tag_origin = c.tag_origin || b.google_tag_origin
        })
    }
    var Yh, Zh = {
        google_ad_client: !0,
        google_ad_host: !0,
        google_adtest: !0,
        google_tag_for_child_directed_treatment: !0,
        google_tag_for_under_age_of_consent: !0,
        google_tag_partner: !0
    },
        $h = Zh;
    Object.isFrozen && !Object.isFrozen(Zh) && ($h = Object.create(Zh), Object.freeze($h));
    Yh = $h;

    function ai(a) {
        delete a.google_checked_head;
        Mb(a, function (b, c) {
            Yh[c] || (delete a[c], b = c.replace("google", "data").replace(/_/g, "-"), q.console.warn("AdSense head tag doesn't support " + b + " attribute."))
        })
    }

    function Xh(a, b) {
        Ba = (new Date).getTime();
        Bh();
        a: {
            if (void 0 != a.enable_page_level_ads) {
                if (r(a.google_ad_client)) {
                    var c = !0;
                    break a
                }
                throw new I("'google_ad_client' is missing from the tag config.");
            }
            c = !1
        }
        if (c) bi(a, b);
        else if ((c = a.params) && kc(c, function (a, c) {
                b[c] = a
        }), "js" === b.google_ad_output) console.warn("Ads with google_ad_output='js' have been deprecated and no longer work. Contact your AdSense account manager or switch to standard AdSense ads.");
        else {
            a = ci(a.element);
            Lh(a, b);
            c = E(q).head_tag_slot_vars || {};
            Mb(c, function (a, c) {
                b.hasOwnProperty(c) || (b[c] = a)
            });
            if (a.hasAttribute("data-require-head") && !E(q).head_tag_slot_vars) throw new I("AdSense head tag is missing. AdSense body tags don't work without the head tag. You can the head tag from your account on https://adsense.com.");
            0 === (E(B).first_tag_on_page || 0) && uf(b) && (c = Af(b.google_ad_client), bi(c), E(B).skip_next_reactive_tag = !0);
            0 === (E(B).first_tag_on_page || 0) && (E(B).first_tag_on_page = 2);
            b.google_pause_ad_requests = E(B).pause_ad_requests || !1;
            Ph(a, b)
        }
    }

    function bi(a, b) {
        if (E(B).skip_next_reactive_tag) E(B).skip_next_reactive_tag = !1;
        else {
            0 === (E(B).first_tag_on_page || 0) && (E(B).first_tag_on_page = 1);
            b && a.tag_partner && (uc(q, a.tag_partner), uc(b, a.tag_partner));
            if (!E(B).ama_ran_on_page) {
                E(B).ama_ran_on_page = !0;
                try {
                    var c = q.localStorage.getItem("google_ama_config")
                } catch (xc) {
                    c = null
                }
                try {
                    var d = c ? new Ec(c ? JSON.parse(c) : null) : null
                } catch (xc) {
                    d = null
                }
                if (b = d)
                    if (c = cb(b, Gc, 3), !c || A(c, 1) <= +new Date) try {
                        q.localStorage.removeItem("google_ama_config")
                    } catch (xc) {
                        Gd(q, {
                            lserr: 1
                        })
                    } else {
                        if (cb(b, Jc, 13)) switch (c = !0, A(cb(b, Jc, 13), 1)) {
                            case 1:
                            case 2:
                            case 3:
                                c = !1;
                            case 4:
                            case 5:
                            case 6:
                                c = void 0 === c ? !1 : c, d = E(q), d.remove_ads_by_default = !0, d.space_collapsing = "slot", d.dont_remove_atf = c
                        }
                        Ld(3, [eb(b)]);
                        c = a.google_ad_client;
                        d = Bd(Dd, new Ad(null, Hd(wa(a.enable_page_level_ads) ? a.enable_page_level_ads : {})));
                        try {
                            a: {
                                for (var e = q.location.pathname, f = db(b, Hc, 7), g = {}, h = 0; h < f.length; ++h) {
                                    var k = A(f[h], 1);
                                    oa(k) && !g[k] && (g[k] = f[h])
                                }
                                for (var n = e.replace(/(^\/)|(\/$)/g, "") ; ;) {
                                    var m = Nb(n);
                                    if (g[m]) {
                                        var p = g[m];
                                        break a
                                    }
                                    if (!n) {
                                        p = null;
                                        break a
                                    }
                                    n = n.substring(0, n.lastIndexOf("/"))
                                }
                            }
                            var t;
                            if (t = p) a: {
                                var y = A(p, 2);
                                if (y)
                                    for (e = 0; e < y.length; e++)
                                        if (1 == y[e]) {
                                            t = !0;
                                            break a
                                        }
                                t = !1
                            }
                            if (t) {
                                if (A(p, 4)) {
                                    t = {};
                                    var Ga = new Ad(null, (t.google_package = A(p, 4), t));
                                    d = Bd(d, Ga)
                                }
                                var N = new cf;
                                (new hf(new $e(c, b, d), N)).start();
                                var Y = N.b;
                                var mb = Aa(lf, q);
                                if (Y.b) throw Error("Then functions already set.");
                                Y.b = Aa(kf, q);
                                Y.g = mb;
                                ff(Y)
                            }
                        } catch (xc) {
                            Gd(q, {
                                atf: -1
                            })
                        }
                    }
            }
            Vh(a)
        }
    }

    function ci(a) {
        if (a) {
            if (!Oh(a) && (a.id ? a = Sh(a.id) : a = null, !a)) throw new I("'element' has already been filled.");
            if (!("innerHTML" in a)) throw new I("'element' is not a good DOM element.");
        } else if (a = Sh(), !a) throw new I("All ins elements in the DOM with class=adsbygoogle already have ads in them.");
        return a
    }

    function di() {
        rd();
        ud(166, zd, ei)
    }

    function ei() {
        var a = jc(ic(B)) || B,
            b = E(a);
        if (!b.plle) {
            b.plle = !0;
            var c = Uf.ja();
            Rf(c);
            b.eids = Ea(c.g, String).concat(b.eids || []);
            b = b.eids;
            c = yf();
            var d = yf();
            var e = tc(a) || a;
            e = nf(e.location, "google_responsive_slot_debug") || nf(e.location, "google_responsive_slot_preview");
            var f = sf(a, 11),
                g = null != qf(a, "");
            e ? (e = J, f = he, d = e.f) : g ? (e = ke, f = le, d = R(a, new G(0, 999, ""), O(d, 152), O(d, 153), [e.c, e.f, e.o, e.o, e.o, e.o, e.s, e.s, e.s, e.s], 2)) : f ? (e = ie, f = je, d = R(a, new G(0, 999, ""), O(d, 120), O(d, 121), [e.c, e.f], 2)) : (e = J, f = he, d = R(a, $f, O(d, 96), O(d, 97), [e.c, e.f]));
            d ? (g = {}, e = (g[e.c] = f.c, g[e.f] = f.f, g[e.o] = f.o, g[e.s] = f.s, g)[d], d = {
                Na: d,
                Pa: e
            }) : d = null;
            e = d || {};
            d = e.Na;
            e = e.Pa;
            d && e && (P(b, d), P(b, e));
            f = Td;
            d = Q(a, O(c, 136), [f.c, f.f]);
            P(b, d);
            sf(a, 12) && (f = Qd, g = Pd, d = R(a, new G(0, 999, ""), O(c, 149), O(c, 150), [f.c, f.f], 4), P(b, d), d == f.c ? e = g.c : d == f.f ? e = g.f : e = "", P(b, e));
            f = Sd;
            d = R(a, Wf, O(c, 160), O(c, 161), [f.c, f.D, f.J]);
            P(b, d);
            g = Rd;
            d == f.c ? e = g.c : d == f.D ? e = g.D : d == f.D ? e = g.J : e = "";
            P(b, e);
            f = ae;
            P(b, R(a, Xf, O(c, 9), O(c, 10), [f.c, f.Aa]));
            Ha("") && P(b, "");
            f = oe;
            d = Q(a, O(c, 146), [f.c, f.f]);
            P(b, d);
            f = be;
            d = Q(a, O(c, 13), [f.m, f.c]);
            P(b, d);
            d = Q(a, 0, [f.$]);
            P(b, d);
            f = ce;
            d = Q(a, O(c, 60), [f.m, f.c]);
            P(b, d);
            d == ce.m && (f = de, d = Q(a, O(c, 66), [f.m, f.c]), P(b, d), f = fe, d = Q(a, O(c, 137), [f.m, f.c]), P(b, d), d == de.m && (f = ee, d = Q(a, O(c, 135), [f.m, f.c]), P(b, d)));
            f = Ud;
            d = Q(a, O(c, 98), [f.c, f.f]);
            P(b, d);
            if (Rb(c.a[77], !1) || dc) f = ge, d = Q(a, O(c, 76), [f.c, f.ca, f.U, f.ba]), P(b, d), d || (d = Q(a, O(c, 83), [f.aa]), P(b, d));
            f = Vd;
            d = R(a, bg, O(c, 157), O(c, 158), [f.c, f.F]);
            P(b, d);
            g = Wd;
            d == f.c ? e = g.c : d == f.F ? e = g.F : e = "";
            P(b, e);
            f = Xd;
            d = R(a, Vf, O(c, 166), O(c, 167), [f.c, f.f]);
            P(b, d);
            g = Yd;
            d == f.c ? e = g.c : d == f.f ? e = g.f : e = "";
            P(b, e);
            f = Zd;
            d = R(a, ag, O(c, 173), O(c, 174), [f.c, f.f]);
            P(b, d);
            g = $d;
            d == f.c ? e = g.c : d == f.f ? e = g.f : e = "";
            P(b, e);
            f = me;
            d = R(a, Zf, O(c, 99), O(c, 100), [f.c, f.f]);
            P(b, d);
            g = ne;
            d == f.c ? e = g.c : d == f.f ? e = g.f : e = "";
            P(b, e);
            f = pe;
            d = Q(a, O(c, 165), [f.c, f.f]);
            P(b, d);
            f = qe;
            d = R(a, Yf, O(c, 169), O(c, 170), [f.c, f.T, f.R]);
            P(b, d);
            if (!ib.body) switch (d) {
                case f.c:
                    P(b, "21062911");
                    break;
                case f.T:
                    P(b, "21062912");
                    break;
                case f.R:
                    P(b, "21062913")
            }
        }
        a = F(B, de.m) || F(B, be.m) || F(B, be.$);
        qd(a);
        if (F(B, ge.ca) || F(B, ge.U) || F(B, ge.ba) || F(B, ge.aa)) wh(), th(".google.co.in") && (X[1] = ".google.co.in"), F(B, ge.U) ? (a = ob(sa), zh(a), yh(a)) : yh(null);
        if (a = tc(q)) a = se(a), a.tagSpecificState[1] || (a.tagSpecificState[1] = new mf);
        if (b = B.document.querySelector('script[src*="/pagead/js/adsbygoogle.js"][data-ad-client]:not([data-checked-head])')) {
            b.setAttribute("data-checked-head", "true");
            c = E(window);
            if (c.head_tag_slot_vars) throw new I("Only one AdSense head tag supported per page. The second tag is ignored.");
            a = {};
            Lh(b, a);
            ai(a);
            c.head_tag_slot_vars = Va(a);
            b = {};
            a = (b.google_ad_client = a.google_ad_client, b.enable_page_level_ads = a, b);
            B.adsbygoogle || (B.adsbygoogle = []);
            b = B.adsbygoogle;
            b.loaded ? b.push(a) : b.splice(0, 0, a)
        }
        a = window.adsbygoogle;
        if (!a || !a.loaded) {
            b = {
                push: Wh,
                loaded: !0
            };
            try {
                Object.defineProperty(b, "requestNonPersonalizedAds", {
                    set: fi
                }), Object.defineProperty(b, "pauseAdRequests", {
                    set: gi
                }), Object.defineProperty(b, "onload", {
                    set: hi
                })
            } catch (k) { }
            a && (void 0 !== a.requestNonPersonalizedAds && (b.requestNonPersonalizedAds = a.requestNonPersonalizedAds), void 0 !== a.pauseAdRequests && (b.pauseAdRequests = a.pauseAdRequests));
            if (a && a.shift) try {
                var h;
                for (c = 20; 0 < a.length && (h = a.shift()) && 0 < c;) Wh(h), --c
            } catch (k) {
                throw window.setTimeout(di, 0), k;
            }
            window.adsbygoogle = b;
            a && (b.onload = a.onload)
        }
    }

    function fi(a) {
        if (+a) {
            if ((a = Eb()) && a.frames && !a.frames.GoogleSetNPA) try {
                var b = a.document,
                    c = new xb(b),
                    d = b.body || b.head && b.head.parentElement;
                if (d) {
                    var e = yb(c, "IFRAME");
                    e.name = "GoogleSetNPA";
                    e.id = "GoogleSetNPA";
                    e.setAttribute("style", "display:none;position:fixed;left:-999px;top:-999px;width:0px;height:0px;");
                    d.appendChild(e)
                }
            } catch (f) { }
        } else (b = Eb().document.getElementById("GoogleSetNPA")) && b.parentNode && b.parentNode.removeChild(b)
    }

    function gi(a) {
        +a ? E(B).pause_ad_requests = !0 : (E(B).pause_ad_requests = !1, a = function () {
            if (!E(B).pause_ad_requests) {
                var a = qc(),
                    c = qc();
                try {
                    if (ib.createEvent) {
                        var d = ib.createEvent("CustomEvent");
                        d.initCustomEvent("adsbygoogle-pub-unpause-ad-requests-event", !1, !1, "");
                        a.dispatchEvent(d)
                    } else if (lc(c.CustomEvent)) {
                        var e = new c.CustomEvent("adsbygoogle-pub-unpause-ad-requests-event", {
                            bubbles: !1,
                            cancelable: !1,
                            detail: ""
                        });
                        a.dispatchEvent(e)
                    } else if (lc(c.Event)) {
                        var f = new Event("adsbygoogle-pub-unpause-ad-requests-event", {
                            bubbles: !1,
                            cancelable: !1
                        });
                        a.dispatchEvent(f)
                    }
                } catch (g) { }
            }
        }, q.setTimeout(a, 0), q.setTimeout(a, 1E3))
    }

    function hi(a) {
        lc(a) && window.setTimeout(a, 0)
    };
    di();
}).call(this);