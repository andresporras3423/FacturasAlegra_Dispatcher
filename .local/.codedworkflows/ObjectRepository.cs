using UiPath.CodedWorkflows.DescriptorIntegration;

namespace FacturasAlegra_Dispatcher.ObjectRepository
{
    public static class Descriptors
    {
        public static class __Chrome_Login___Ingreso_a_Alegra_Contabilidad
        {
            static string _reference = "ryTY7yfCSU-sIFT8MhIkwQ/p-JwHVUepkyLbghhK8QMcw";
            public static _Implementation.___Chrome_Login___Ingreso_a_Alegra_Contabilidad.__Chrome_Facturas_de_venta Chrome_Facturas_de_venta { get; private set; } = new _Implementation.___Chrome_Login___Ingreso_a_Alegra_Contabilidad.__Chrome_Facturas_de_venta();
            public static _Implementation.___Chrome_Login___Ingreso_a_Alegra_Contabilidad.__Chrome_Login___Ingreso_a_Alegra_Contabilidad Chrome_Login___Ingreso_a_Alegra_Contabilidad { get; private set; } = new _Implementation.___Chrome_Login___Ingreso_a_Alegra_Contabilidad.__Chrome_Login___Ingreso_a_Alegra_Contabilidad();
        }

        public static class __Guardar_como
        {
            static string _reference = "ryTY7yfCSU-sIFT8MhIkwQ/hWe3NMZIdkm9seGKRntvoA";
            public static _Implementation.___Guardar_como.__Chrome_Facturas_de_venta Chrome_Facturas_de_venta { get; private set; } = new _Implementation.___Guardar_como.__Chrome_Facturas_de_venta();
            public static _Implementation.___Guardar_como.__Guardar_como Guardar_como { get; private set; } = new _Implementation.___Guardar_como.__Guardar_como();
        }
    }
}

namespace FacturasAlegra_Dispatcher._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
        public IElementDescriptor ParentElement { get; set; }
        public IElementDescriptor Element { get; set; }
    }

    namespace ___Chrome_Login___Ingreso_a_Alegra_Contabilidad
    {
        public class __Chrome_Facturas_de_venta : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Chrome_Facturas_de_venta()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "ryTY7yfCSU-sIFT8MhIkwQ/7nTn6-UfB0yL_uxO2-6HxQ",
                    DisplayName = "Chrome Facturas de venta",
                    Screen = this
                };
            }
        }
    }

    namespace ___Chrome_Login___Ingreso_a_Alegra_Contabilidad._Chrome_Login___Ingreso_a_Alegra_Contabilidad
    {
        public class __Correo_electrónico : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Correo_electrónico(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "ryTY7yfCSU-sIFT8MhIkwQ/_Uz2UEtzr0SbxUY8EN1lVQ",
                    DisplayName = "Correo electrónico",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Login___Ingreso_a_Alegra_Contabilidad._Chrome_Login___Ingreso_a_Alegra_Contabilidad
    {
        public class __Enviar_link_mágico : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Enviar_link_mágico(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "ryTY7yfCSU-sIFT8MhIkwQ/0S2gHPFR20WsYR48TLstZQ",
                    DisplayName = "Enviar link mágico",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Login___Ingreso_a_Alegra_Contabilidad._Chrome_Login___Ingreso_a_Alegra_Contabilidad
    {
        public class __Extract_Table_Data : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Extract_Table_Data(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "ryTY7yfCSU-sIFT8MhIkwQ/b2WyCkFIIkmxBY6rNVlz3w",
                    DisplayName = "Extract Table Data",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Login___Ingreso_a_Alegra_Contabilidad._Chrome_Login___Ingreso_a_Alegra_Contabilidad
    {
        public class __Ingresar_desde_mi_correo : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Ingresar_desde_mi_correo(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "ryTY7yfCSU-sIFT8MhIkwQ/lcOD9BkJnkWa_psO7sWP8A",
                    DisplayName = "Ingresar desde mi correo",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Login___Ingreso_a_Alegra_Contabilidad._Chrome_Login___Ingreso_a_Alegra_Contabilidad
    {
        public class __Label : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Label(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "ryTY7yfCSU-sIFT8MhIkwQ/neYCtOhrNEK_ORqKElGUuA",
                    DisplayName = "Label",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Login___Ingreso_a_Alegra_Contabilidad._Chrome_Login___Ingreso_a_Alegra_Contabilidad
    {
        public class __svg : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __svg(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "ryTY7yfCSU-sIFT8MhIkwQ/O2JHdy2dnEuTUJ9rbfskvg",
                    DisplayName = "svg",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_Login___Ingreso_a_Alegra_Contabilidad
    {
        public class __Chrome_Login___Ingreso_a_Alegra_Contabilidad : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Chrome_Login___Ingreso_a_Alegra_Contabilidad()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "ryTY7yfCSU-sIFT8MhIkwQ/MZHGqS0Tv0aj8gXxKje8KQ",
                    DisplayName = "Chrome Login - Ingreso a Alegra Contabilidad",
                    Screen = this
                };
                Correo_electrónico = new _Implementation.___Chrome_Login___Ingreso_a_Alegra_Contabilidad._Chrome_Login___Ingreso_a_Alegra_Contabilidad.__Correo_electrónico(this, null);
                Enviar_link_mágico = new _Implementation.___Chrome_Login___Ingreso_a_Alegra_Contabilidad._Chrome_Login___Ingreso_a_Alegra_Contabilidad.__Enviar_link_mágico(this, null);
                Extract_Table_Data = new _Implementation.___Chrome_Login___Ingreso_a_Alegra_Contabilidad._Chrome_Login___Ingreso_a_Alegra_Contabilidad.__Extract_Table_Data(this, null);
                Ingresar_desde_mi_correo = new _Implementation.___Chrome_Login___Ingreso_a_Alegra_Contabilidad._Chrome_Login___Ingreso_a_Alegra_Contabilidad.__Ingresar_desde_mi_correo(this, null);
                Label = new _Implementation.___Chrome_Login___Ingreso_a_Alegra_Contabilidad._Chrome_Login___Ingreso_a_Alegra_Contabilidad.__Label(this, null);
                svg = new _Implementation.___Chrome_Login___Ingreso_a_Alegra_Contabilidad._Chrome_Login___Ingreso_a_Alegra_Contabilidad.__svg(this, null);
            }

            public _Implementation.___Chrome_Login___Ingreso_a_Alegra_Contabilidad._Chrome_Login___Ingreso_a_Alegra_Contabilidad.__Correo_electrónico Correo_electrónico { get; private set; }
            public _Implementation.___Chrome_Login___Ingreso_a_Alegra_Contabilidad._Chrome_Login___Ingreso_a_Alegra_Contabilidad.__Enviar_link_mágico Enviar_link_mágico { get; private set; }
            public _Implementation.___Chrome_Login___Ingreso_a_Alegra_Contabilidad._Chrome_Login___Ingreso_a_Alegra_Contabilidad.__Extract_Table_Data Extract_Table_Data { get; private set; }
            public _Implementation.___Chrome_Login___Ingreso_a_Alegra_Contabilidad._Chrome_Login___Ingreso_a_Alegra_Contabilidad.__Ingresar_desde_mi_correo Ingresar_desde_mi_correo { get; private set; }
            public _Implementation.___Chrome_Login___Ingreso_a_Alegra_Contabilidad._Chrome_Login___Ingreso_a_Alegra_Contabilidad.__Label Label { get; private set; }
            public _Implementation.___Chrome_Login___Ingreso_a_Alegra_Contabilidad._Chrome_Login___Ingreso_a_Alegra_Contabilidad.__svg svg { get; private set; }
        }
    }

    namespace ___Guardar_como._Chrome_Facturas_de_venta
    {
        public class __Descargar_PDF : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Descargar_PDF(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "ryTY7yfCSU-sIFT8MhIkwQ/PespI0M9zEqeJcXsXPD9NQ",
                    DisplayName = "Descargar PDF",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Guardar_como
    {
        public class __Chrome_Facturas_de_venta : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Chrome_Facturas_de_venta()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "ryTY7yfCSU-sIFT8MhIkwQ/KNxWHCspMUa8Z6HHeHBU2w",
                    DisplayName = "Chrome Facturas de venta",
                    Screen = this
                };
                Descargar_PDF = new _Implementation.___Guardar_como._Chrome_Facturas_de_venta.__Descargar_PDF(this, null);
            }

            public _Implementation.___Guardar_como._Chrome_Facturas_de_venta.__Descargar_PDF Descargar_PDF { get; private set; }
        }
    }

    namespace ___Guardar_como._Guardar_como
    {
        public class ___Guardar : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___Guardar(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "ryTY7yfCSU-sIFT8MhIkwQ/HSz2MEklLEKh21Uyj7pTsA",
                    DisplayName = "&Guardar",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Guardar_como._Guardar_como
    {
        public class __Nombre_de_archivo : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Nombre_de_archivo(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "ryTY7yfCSU-sIFT8MhIkwQ/6xwGCrMgKEaZ2FqiYJ0mkA",
                    DisplayName = "Nombre de archivo",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Guardar_como
    {
        public class __Guardar_como : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Guardar_como()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "ryTY7yfCSU-sIFT8MhIkwQ/v9SiTQtnQEG16TNm4Hmlcw",
                    DisplayName = "Guardar como",
                    Screen = this
                };
                _Guardar = new _Implementation.___Guardar_como._Guardar_como.___Guardar(this, null);
                Nombre_de_archivo = new _Implementation.___Guardar_como._Guardar_como.__Nombre_de_archivo(this, null);
            }

            public _Implementation.___Guardar_como._Guardar_como.___Guardar _Guardar { get; private set; }
            public _Implementation.___Guardar_como._Guardar_como.__Nombre_de_archivo Nombre_de_archivo { get; private set; }
        }
    }
}