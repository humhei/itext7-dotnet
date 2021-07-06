/*
This file is part of the iText (R) project.
Copyright (c) 1998-2021 iText Group NV
Authors: iText Software.

This program is offered under a commercial and under the AGPL license.
For commercial licensing, contact us at https://itextpdf.com/sales.  For AGPL licensing, see below.

AGPL licensing:
This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Affero General Public License for more details.

You should have received a copy of the GNU Affero General Public License
along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/
using System;
using iText.Kernel.Actions.Data;
using iText.Kernel.Counter.Event;

namespace iText.Kernel.Actions {
    /// <summary>Represents a context-based event.</summary>
    /// <remarks>
    /// Represents a context-based event. See also
    /// <see cref="AbstractContextBasedEventHandler"/>.
    /// Only for internal usage.
    /// </remarks>
    public abstract class AbstractContextBasedITextEvent : AbstractProductITextEvent {
        private readonly IMetaInfo metaInfo;

        /// <summary>Creates an event containing auxiliary meta data.</summary>
        /// <param name="productData">is a description of the product which has generated an event</param>
        /// <param name="metaInfo">is an auxiliary meta info</param>
        public AbstractContextBasedITextEvent(ProductData productData, IMetaInfo metaInfo)
            : base(productData) {
            this.metaInfo = metaInfo;
        }

        /// <summary>Obtains stored meta info associated with the event.</summary>
        /// <returns>meta info</returns>
        internal virtual IMetaInfo GetMetaInfo() {
            return metaInfo;
        }

        /// <summary>Obtains a current event context class.</summary>
        /// <returns>context class</returns>
        public virtual Type GetClassFromContext() {
            return this.GetType();
        }
    }
}
