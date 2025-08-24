# Paleta de Colores - Sistema de Facturación

## Paleta Principal (Morados Elegantes)

### Colores Primarios
- **Morado Principal**: `#A587C3` - RGB(165, 135, 195)
  - Uso: Paneles principales, headers, footers, logos
  
- **Morado Oscuro**: `#8E6BA8` - RGB(142, 107, 168)  
  - Uso: Hover states, elementos activos, cards secundarias
  
- **Morado Claro**: `#C8A8D8` - RGB(200, 168, 216)
  - Uso: Accents, elementos destacados, cards terciarias

### Colores Neutros
- **Blanco**: `#FFFFFF` - RGB(255, 255, 255)
  - Uso: Fondos principales, texto en elementos oscuros
  
- **Gris Claro**: `#F5F5F5` - RGB(245, 245, 245)
  - Uso: Fondos secundarios, separadores sutiles
  
- **Gris Medio**: `#C8C8C8` - RGB(200, 200, 200)
  - Uso: Bordes, splitters, elementos divisorios
  
- **Gris Oscuro**: `#787878` - RGB(120, 120, 120)
  - Uso: Texto secundario, elementos menos importantes

### Aplicación de Colores

#### Login (frmLogin)
- Panel izquierdo: Morado Principal (#A587C3)
- Panel derecho: Blanco (#FFFFFF)
- Footer: Morado Principal (#A587C3)

#### Principal (frmPrincipal)  
- Header/Menú: Morado Principal (#A587C3)
- Panel lateral: Gris Claro (#DCDCDC)
- Área de contenido: Blanco (#FFFFFF)
- Footer: Morado Principal (#A587C3)

#### Dashboard Cards
- Card 1 (Facturas): Morado Principal (#A587C3)
- Card 2 (Clientes): Morado Oscuro (#8E6BA8)
- Card 3 (Ventas): Morado Claro (#C8A8D8)
- Card 4 (Pendientes): Gris Oscuro (#787878)

### Reglas de Uso
1. **NO usar colores azules** en ninguna parte de la aplicación
2. Mantener consistencia con la paleta morada en todos los formularios
3. Usar blanco para fondos principales y legibilidad
4. Usar grises para elementos secundarios y separadores
5. El morado principal (#A587C3) es el color corporativo de la aplicación

### MaterialSkin Configuration
```csharp
manager.ColorScheme = new ColorScheme(
    Primary.Purple600, // #A587C3 - Color principal
    Primary.Purple700, // #8E6BA8 - Color más oscuro para hover
    Primary.Purple300, // #C8A8D8 - Color más claro para accents
    Accent.Purple200,  // Acento morado claro
    TextShade.WHITE
);
```