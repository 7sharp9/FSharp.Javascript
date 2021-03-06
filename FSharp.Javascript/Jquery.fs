﻿module FSharp.Javascript.Jquery

open FSharp.Javascript.Dom

type browser() =
    [<DefaultValue>]
    val mutable webkit : bool
    [<DefaultValue>]
    val mutable msie : bool
    [<DefaultValue>]
    val mutable opera : bool
    [<DefaultValue>]
    val mutable mozilla : bool
    [<DefaultValue>]
    val mutable version : string

type event() =
    [<DefaultValue>]
    val mutable currentTarget : obj
    [<DefaultValue>]
    val mutable data : obj
    [<DefaultValue>]
    val mutable pageX : float
    [<DefaultValue>]
    val mutable pageY : float
    [<DefaultValue>]
    val mutable relatedTarget : HtmlElement
    [<DefaultValue>]
    val mutable result : obj
    [<DefaultValue>]
    val mutable target : HtmlElement
    [<DefaultValue>]
    val mutable timeStamp : obj
    [<DefaultValue>]
    val mutable ``type`` : obj
    [<DefaultValue>]
    val mutable which : obj
    [<DefaultValue>]
    val mutable keyCode : float


    member this.isDefaultPrevented() = true
    member this.isImmediatePropagationStopped() = true
    member this.isPropagationStopped() = true
    member this.preventDefault() = ()
    member this.stopImmediatePropagation() = ()
    member this.stopPropagation() = ()

type position() =
    [<DefaultValue>]
    val mutable top : float
    [<DefaultValue>]
    val mutable left : float

type support() =
    [<DefaultValue>]
    val mutable boxModel : bool
    [<DefaultValue>]
    val mutable cssFloat : bool
    [<DefaultValue>]
    val mutable hrefNormalized : bool
    [<DefaultValue>]
    val mutable htmlSerialize : bool
    [<DefaultValue>]
    val mutable leadingWhitespace : bool
    [<DefaultValue>]
    val mutable noCloneEvent : bool
    [<DefaultValue>]
    val mutable objectAll : bool
    [<DefaultValue>]
    val mutable opacity : bool
    [<DefaultValue>]
    val mutable scriptEval : bool
    [<DefaultValue>]
    val mutable style : bool
    [<DefaultValue>]
    val mutable tbody : bool


type jquery(x:System.Object) =
    inherit System.Collections.Generic.List<HtmlElement>()
    member this.add(x) = new jquery(null)
    member this.addClass(x) = new jquery(null)
    member this.after(x) = new jquery(null)
    member this.ajaxComplete(x) = new jquery(null)
    member this.ajaxError(x) = new jquery(null)
    member this.ajaxSend(x) = new jquery(null)
    member this.ajaxStart(x) = new jquery(null)
    member this.ajaxStop(x) = new jquery(null)
    member this.ajaxSuccess(x) = new jquery(null)
    member this.andSelf() = new jquery(null)
    member this.animate(x, y) = new jquery(null)
    member this.animate(x,y,z) = new jquery(null)
    member this.animate(x,y,z,q) = new jquery(null)
    member this.append(x) = new jquery(null)
    member this.appendTo(x) = new jquery(null)
    member this.attr(x) = ""
    member this.before(x) = new jquery(null)
    member this.bind(eventType) = new jquery(null)
    member this.bind(x,y) = new jquery(null)
    member this.bind(x,y,z) = new jquery(null)
    member this.blur(x) = new jquery(null)
    member this.change(x) = new jquery(null)
    member this.children() = new jquery(null)
    member this.children(selector) = new jquery(null)
    member this.clearQueue() = new jquery(null)
    member this.clearQueue(queueName) = new jquery(null)
    member this.click() = new jquery(null)
    member this.click(handler) = new jquery(null)
    member this.clone() = new jquery(null)
    member this.clone(x) = new jquery(null)
    member this.closest(x) = new jquery(null)
    member this.closest(x,y) = new jquery(null)
    member this.contents() = new jquery(null)
    member this.css(x) = new jquery(null)
    member this.css(x,y) = new jquery(null)
    member this.data(key) = new System.Object()
    member this.data(key,value) = ()
    member this.dblclick() = new jquery(null)
    member this.dblclick(x) = new jquery(null)
    member this.delay(x) = new jquery(null)
    member this.delay(x,y) = new jquery(null)
    member this.``delegate``(selector,eventType,handler) = new jquery(null)
    member this.``delegate``(selector,eventType,eventData,handler) = new jquery(null)
    member this.dequeue() = new jquery(null)
    member this.dequeue(x) = new jquery(null)
    member this.detach() = new jquery(null)
    member this.detach(selector) = new jquery(null)
    member this.die() = new jquery(null)
    member this.die(eventType) = new jquery(null)
    member this.die(eventType,handler) = new jquery(null)
    member this.each(callback) = new jquery(null)
    member this.empty() = new jquery(null)
    member this.``end``() = new jquery(null)
    member this.eq(x) = new jquery(null)
    member this.error(x) = new jquery(null)
    member this.fadeIn() = new jquery(null)
    member this.fadeIn(x) = new jquery(null)
    member this.fadeIn(x,y) = new jquery(null)
    member this.fadeOut() = new jquery(null)
    member this.fadeOut(x) = new jquery(null)
    member this.fadeOut(x,y) = new jquery(null)
    member this.fadeTo(duration,opacity) = new jquery(null)
    member this.fadeTo(duration,opacity,callback) = new jquery(null)
    member this.filter(x) = new jquery(null)
    member this.find(x:string) = new jquery(null)
    member this.first() = new jquery(null)
    member this.focus() = new jquery(null)
    member this.focus(handler) = new jquery(null)
    member this.focusin(x) = new jquery(null)
    member this.focusout(x) = new jquery(null)
    member this.get(x) = new HtmlElement()
    member this.has(x) = new jquery(null)
    member this.hasClass(x) = new jquery(null)
    member this.height() = new jquery(null)
    member this.height(x) = new jquery(null)
    member this.hide() = new jquery(null)
    member this.hide(x) = new jquery(null)
    member this.hide(x,y) = new jquery(null)
    member this.hover(x) = new jquery(null)
    member this.hover(x,y) = new jquery(null)
    member this.html() = ""
    member this.html(x) = new jquery(null)
    member this.index() = 0
    member this.index(x) = 0
    member this.innerHeight() = 1.0
    member this.innerWidth() = 1.0
    member this.insertAfter(x) = new jquery(null)
    member this.insertBefore(x) = new jquery(null)
    member this.is(x) = true
    member this.keydown() = new jquery(null)
    member this.keydown(x : event -> unit) = new jquery(null)
    member this.keydown(x : event -> bool) = new jquery(null)
    member this.keypress() = new jquery(null)
    member this.keypress(x : event -> unit) = new jquery(null)
    member this.keypress(x : event -> bool) = new jquery(null)
    member this.keyup() = new jquery(null)
    member this.keyup(x:event -> unit) = new jquery(null)
    member this.keyup(x:event -> bool) = new jquery(null)
    member this.last() = new jquery(null)
    [<DefaultValue>]
    val mutable length : float
    member this.live(eventType, handler) = new jquery(null)
    member this.live(eventType,eventData,handler) = new jquery(null)
    member this.load(a) = new jquery(null)
    member this.load(a,b) = new jquery(null)
    member this.load(a,b,c) = new jquery(null)
    member this.map(x) = new jquery(null)
    member this.mousedown() = new jquery(null)
    member this.mousedown(x: event -> unit) = new jquery(null)
    member this.mouseenter() = new jquery(null)
    member this.mouseenter(x: event -> unit) = new jquery(null)
    member this.mouseleave() = new jquery(null)
    member this.mouseleave(x: event -> unit) = new jquery(null)
    member this.mousemove() = new jquery(null)
    member this.mousemove(x: event -> unit) = new jquery(null)
    member this.mouseout() = new jquery(null)
    member this.mouseout(x: event -> unit) = new jquery(null)
    member this.mouseover() = new jquery(null)
    member this.mouseover(x: event -> unit) = new jquery(null)
    member this.mouseup() = new jquery(null)
    member this.mouseup(x: event -> unit) = new jquery(null)
    member this.next() = new jquery(null)
    member this.next(x) = new jquery(null)
    member this.nextAll() = new jquery(null)
    member this.nextAll(x) = new jquery(null)
    member this.nextUntil() = new jquery(null)
    member this.nextUntil(x) = new jquery(null)
    member this.not(x) = new jquery(null)
    member this.offset() = new position()
    member this.offset(x) = new position()
    member this.offsetParent() = new position()
    member this.one(x) = new jquery(null)
    member this.one(x,y) = new jquery(null)
    member this.one(x,y,z) = new jquery(null)
    member this.outerHeight() = 0
    member this.outerHeight(x) = 0
    member this.outerWidth() = 0
    member this.outerWidth(x) = 0
    member this.parent() = new jquery(null)
    member this.parent(x) = new jquery(null)
    member this.parents() = new jquery(null)
    member this.parents(x) = new jquery(null)
    member this.parentsUntil() = new jquery(null)
    member this.parentsUntil(x) = new jquery(null)
    member this.position() = new position()
    member this.prepend(x) = new jquery(null)
    member this.prependTo(x) = new jquery(null)
    member this.prev() = new jquery(null)
    member this.prev(x) = new jquery(null)
    member this.prevAll() = new jquery(null)
    member this.prevAll(x) = new jquery(null)
    member this.prevUntil() = new jquery(null)
    member this.prevUntil(x) = new jquery(null)
    member this.queue() = [||]
    member this.queue(x) = [||]
    member this.queue(x,y) = [||]
    member this.ready(x) = new jquery(null)
    member this.remove() = new jquery(null)
    member this.remove(x) = new jquery(null)
    member this.removeAttr(x) = new jquery(null)
    member this.removeClass(x) = new jquery(null)
    member this.removeData(x) = new jquery(null)
    member this.replaceAll() = new jquery(null)
    member this.replaceAll(x) = new jquery(null)
    member this.replaceWith(x) = new jquery(null)
    member this.resize() = new jquery(null)
    member this.resize(x) = new jquery(null)
    member this.scroll() = new jquery(null)
    member this.scroll(x) = new jquery(null)
    member this.scrollLeft() = 0
    member this.scrollLeft(x) = 0
    member this.scrollTop() = 0
    member this.scrollTop(x) = 0
    member this.select() = new jquery(null)
    member this.select(x) = new jquery(null)
    [<DefaultValue>]
    val mutable selector : string
    member this.serialize() = ""
    member this.serializeArray() = [||]
    member this.show() = new jquery(null)
    member this.show(x) = new jquery(null)
    member this.show(x,y) = new jquery(null)
    member this.siblings() = new jquery(null)
    member this.siblings(x) = new jquery(null)
    member this.size() = 0
    member this.slice(start) = new jquery(null)
    member this.slice(start,e) = new jquery(null)
    member this.slideDown() = new jquery(null)
    member this.slideDown(x) = new jquery(null)
    member this.slideDown(x,y) = new jquery(null)
    member this.slideToggle() = new jquery(null)
    member this.slideToggle(x) = new jquery(null)
    member this.slideToggle(x,y) = new jquery(null)
    member this.slideUp() = new jquery(null)
    member this.slideUp(x) = new jquery(null)
    member this.slideUp(x,y) = new jquery(null)
    member this.stop() = new jquery(null)
    member this.stop(x) = new jquery(null)
    member this.stop(x,y) = new jquery(null)
    member this.submit() = new jquery(null)
    member this.submit(x) = new jquery(null)
    member this.text() = ""
    member this.toArray() = [||]
    member this.toggle() = new jquery(null)
    member this.toggle(x) = new jquery(null)
    member this.toggle(x,y) = new jquery(null)
    member this.toggle(x,y,z) = new jquery(null)
    member this.toggleClass(x) = new jquery(null)
    member this.toggleClass(x,y) = new jquery(null)
    member this.trigger() = new jquery(null)
    member this.trigger(x) = new jquery(null)
    member this.trigger(x,y) = new jquery(null)
    member this.triggerHandler() = new System.Object()
    member this.triggerHandler(x) = new System.Object()
    member this.triggerHandler(x,y) = new System.Object()
    member this.unbind(x) = new jquery(null)
    member this.unbind(x,y) = new jquery(null)
    member this.undelegate(x,y) = new jquery(null)
    member this.undelegate(x,y,z) = new jquery(null)
    member this.unload(x) = new jquery(null)
    member this.unwrap() = new jquery(null)
    member this.value() = new System.Object()
    member this.value(x) = new System.Object()
    member this.width() = 0
    member this.width(x) = 0
    member this.wrap(x) = new jquery(null)
    member this.wrapAll(x) = new jquery(null)
    member this.wrapInner(x) = new jquery(null)


    static member ajax(x) = ()
    static member ajaxSetup(x) = ()
    static member browser
        with get() = new browser()

    static member contains(container, contained) = true
    static member data(element, key) = new System.Object()
    static member data(element, key, value) = ()
    static member dequeue(element) = ()
    static member dequeue(element, queueName) = ()
    static member each(collection, callback) = ()
    static member error(message) = ()
    static member extend(x) = ()
    static member extend(x,y) = ()
    static member extend(x,y,z) = ()
    static member extend(x,y,z,q) = ()
    static member get(a) = ()
    static member get(a,b) = ()
    static member get(a,b,c) = ()
    static member get(a,b,c,d) = ()
    static member getJSON(a) = ()
    static member getJSON(a,b) = ()
    static member getJSON(a,b,c) = ()
    static member getJSON(a,b,c,d) = ()
    static member getScript(a) = ()
    static member getScript(a,b) = ()
    static member globalEval(x) = ()
    static member grep(x) = [||]
    static member grep(x,y) = [||]
    static member grep(x,y,z) = [||]
    static member inArray(x,y) = 0
    static member isArray(x) = true
    static member isEmptyObject(x) = true
    static member isFunction(x) = true
    static member isPlainObject(x) = true
    static member isXMLDoc(x) = true
    static member makeArray(x) = [||]
    static member map(x,y) = [||]
    static member merge(x,y) = [||]
    static member noConflict() = ()
    static member noConflict(x) = ()
    static member noop() = ()
    static member param(x) = ""
    static member param(x,y) = ""
    static member parseJSON(x) = new System.Object()
    static member post(a) = new System.Object()
    static member post(a,b) = new System.Object()
    static member post(a,b,c) = new System.Object()
    static member post(a,b,c,d) = new System.Object()
    static member proxy(x,y) = x
    static member pushStack(x) = new jquery(null)
    static member pushStack(x,y,z) = new jquery(null)


    static member queue(x) = [||] : obj array
    static member queue(a,b) = [||] : obj array
    static member queue(c,y,z) = [||] : obj array
    //uncommenting this gives a very strange error.
    //static member removeData(element) = new jquery(null)
    static member removeData(element, name) = new jquery(null)
    
    static member support = new support()
    static member trim(x:string) = ""
    static member unique(x) = [||]