//------------------------------------------------------------------------------
// <copyright file="DragEventHandler.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                                                                
//------------------------------------------------------------------------------

namespace System.Windows.Forms {

    using System.Diagnostics;

    using System;
    using System.Drawing;

    /// <include file='doc\DragEventHandler.uex' path='docs/doc[@for="DragEventHandler"]/*' />
    /// <devdoc>
    ///    <para>
    ///       Represents the method that will handle
    ///       the <see cref='System.Windows.Forms.Control.DragDrop'/>,
    ///    <see cref='System.Windows.Forms.Control.DragEnter'/>, or <see cref='System.Windows.Forms.Control.DragOver'/> event of a <see cref='System.Windows.Forms.Control'/>.
    ///    </para>
    /// </devdoc>
    public delegate void DragEventHandler(object sender, DragEventArgs e);
}
