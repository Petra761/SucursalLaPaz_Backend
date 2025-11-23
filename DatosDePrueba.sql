INSERT INTO public."Sucursal" (id, codigo, nombre, direccion, ciudad, departamento, ultima_actualizacion)
VALUES (gen_random_uuid(), 'LP-001', 'Leches de MIPALO', 'Av. Siempre Viva #123', 'La Paz', 'La Paz', '2004-02-03 00:00:00.000');



INSERT INTO public."Solicitud" (id, codigo, codigo_solicitante, codigo_destino, tipo_solicitud, asunto, descripcion, estado, prioridad, fecha_creacion, fecha_aprobacion_rechazo, codigo_aprobador_rechazador, justificacion_rechazo, ultima_actualizacion)
VALUES
(gen_random_uuid(), 'SOL-202301-001', 'EMP-005', 'DEPTO-LOG', 'Traspaso Inventario', 'Solicitud de Traspaso: Mercadería de Sucursal LP-001', 'Se requiere trasladar 50 unidades de leche entera y 30 de yogurt natural a la sucursal de El Alto.', 'Aprobada', 'Alta', '2023-01-15', '2023-01-16', 'ADM-001', NULL, NOW()),
(gen_random_uuid(), 'SOL-202301-002', 'EMP-010', 'SUC-CBBA', 'Pedido Interno', 'Pedido de Suministros de Oficina', 'Necesitamos resmas de papel, bolígrafos y cartuchos de tinta para la sucursal de Cochabamba.', 'PendienteAprobacion', 'Media', '2023-01-17', NULL, NULL, NULL, NOW()),
(gen_random_uuid(), 'SOL-202301-003', 'EMP-015', 'DEPTO-SOP', 'Soporte Técnico', 'Falla en el Sistema POS de Sucursal LP-001', 'El sistema de punto de venta ha estado presentando errores al registrar ventas en la caja 3.', 'EnProceso', 'Urgente', '2023-01-18', NULL, NULL, NULL, NOW()),
(gen_random_uuid(), 'SOL-202302-001', 'EMP-008', 'DEPTO-RRHH', 'Vacaciones', 'Solicitud de Vacaciones: EMP-008 (Febrero)', 'El empleado Juan Pérez solicita vacaciones del 5 al 19 de febrero.', 'Aprobada', 'Baja', '2023-01-20', '2023-01-22', 'RRHH-001', NULL, NOW()),
(gen_random_uuid(), 'SOL-202302-002', 'EMP-020', 'DEPTO-MANT', 'Mantenimiento', 'Revisión de Refrigeradores en Sucursal LP-001', 'Los refrigeradores de lácteos están haciendo un ruido extraño y la temperatura no es constante.', 'PendienteAprobacion', 'Alta', '2023-02-01', NULL, NULL, NULL, NOW()),
(gen_random_uuid(), 'SOL-202302-003', 'EMP-005', 'DEPTO-FIN', 'Reembolso Gastos', 'Reembolso por Compra de Materiales de Limpieza', 'Adjunto facturas por la compra de insumos de limpieza para la sucursal LP-001.', 'EnRevision', 'Media', '2023-02-05', NULL, NULL, NULL, NOW()),
(gen_random_uuid(), 'SOL-202302-004', 'EMP-012', 'DEPTO-MARK', 'Material Publicitario', 'Pedido de Banners para Promoción de Verano', 'Necesitamos nuevos banners para la promoción de verano de yogures frutales.', 'Rechazada', 'Media', '2023-02-07', '2023-02-09', 'ADM-002', 'Presupuesto no disponible para este trimestre.', NOW()),
(gen_random_uuid(), 'SOL-202303-001', 'EMP-018', 'SUC-SCZ', 'Traspaso Inventario', 'Solicitud de Traspaso Urgente: Leche Deslactosada', 'Se requiere enviar 100 unidades de leche deslactosada a la sucursal de Santa Cruz debido a alta demanda.', 'PendienteAprobacion', 'Urgente', '2023-03-01', NULL, NULL, NULL, NOW()),
(gen_random_uuid(), 'SOL-202303-002', 'EMP-007', 'DEPTO-COMP', 'Compra', 'Compra de Nuevos Uniformes para Personal', 'Necesitamos cotizar y adquirir 20 uniformes nuevos para el personal de ventas.', 'EnProceso', 'Baja', '2023-03-05', NULL, NULL, NULL, NOW()),
(gen_random_uuid(), 'SOL-202303-003', 'EMP-003', 'DEPTO-SOP', 'Configuración Red', 'Problemas de Conectividad en Oficinas Administrativas', 'La conexión a internet en el área de administración está intermitente. Revisar router y cableado.', 'PendienteAprobacion', 'Alta', '2023-03-10', NULL, NULL, NULL, NOW());



INSERT INTO public."ReporteVentaDiaria" (id, codigo, cod_sucursal, fecha, total_ventas, cantidad_pedidos, total_productos_vendidos, ultima_actualizacion)
VALUES
(gen_random_uuid(), 'RVD-LP001-20230301', 'LP-001', '2023-03-01', 1520.50, 45, 180, NOW()),
(gen_random_uuid(), 'RVD-LP001-20230302', 'LP-001', '2023-03-02', 1850.75, 55, 210, NOW()),
(gen_random_uuid(), 'RVD-LP001-20230303', 'LP-001', '2023-03-03', 1300.20, 40, 160, NOW()),
(gen_random_uuid(), 'RVD-SCZ001-20230301', 'SCZ-001', '2023-03-01', 2100.00, 70, 250, NOW()), -- Suponiendo otra sucursal
(gen_random_uuid(), 'RVD-SCZ001-20230302', 'SCZ-001', '2023-03-02', 2350.90, 75, 280, NOW()), -- Suponiendo otra sucursal
(gen_random_uuid(), 'RVD-LP001-20230304', 'LP-001', '2023-03-04', 1680.00, 50, 195, NOW()),
(gen_random_uuid(), 'RVD-CBBA001-20230301', 'CBBA-001', '2023-03-01', 1750.30, 60, 220, NOW()), -- Suponiendo otra sucursal
(gen_random_uuid(), 'RVD-LP001-20230305', 'LP-001', '2023-03-05', 1990.40, 62, 230, NOW()),
(gen_random_uuid(), 'RVD-LP001-20230306', 'LP-001', '2023-03-06', 1450.10, 48, 175, NOW()),
(gen_random_uuid(), 'RVD-SCZ001-20230303', 'SCZ-001', '2023-03-03', 2050.60, 68, 240, NOW()); -- Suponiendo otra sucursal



INSERT INTO public."ReporteRendimientoLaboralDiario" (id, codigo, cod_sucursal, fecha, empleados_activos, horas_trabajadas_totales, costo_laboral_total, ultima_actualizacion)
VALUES
(gen_random_uuid(), 'RRLD-LP001-20230301', 'LP-001', '2023-03-01', 8, 64.0, 1280.00, NOW()),
(gen_random_uuid(), 'RRLD-LP001-20230302', 'LP-001', '2023-03-02', 7, 56.0, 1120.00, NOW()),
(gen_random_uuid(), 'RRLD-SCZ001-20230301', 'SCZ-001', '2023-03-01', 12, 96.0, 1920.00, NOW()), -- Suponiendo otra sucursal
(gen_random_uuid(), 'RRLD-LP001-20230303', 'LP-001', '2023-03-03', 9, 72.0, 1440.00, NOW()),
(gen_random_uuid(), 'RRLD-CBBA001-20230301', 'CBBA-001', '2023-03-01', 10, 80.0, 1600.00, NOW()), -- Suponiendo otra sucursal
(gen_random_uuid(), 'RRLD-LP001-20230304', 'LP-001', '2023-03-04', 8, 64.0, 1280.00, NOW()),
(gen_random_uuid(), 'RRLD-SCZ001-20230302', 'SCZ-001', '2023-03-02', 11, 88.0, 1760.00, NOW()), -- Suponiendo otra sucursal
(gen_random_uuid(), 'RRLD-LP001-20230305', 'LP-001', '2023-03-05', 7, 56.0, 1120.00, NOW()),
(gen_random_uuid(), 'RRLD-CBBA001-20230302', 'CBBA-001', '2023-03-02', 9, 72.0, 1440.00, NOW()), -- Suponiendo otra sucursal
(gen_random_uuid(), 'RRLD-LP001-20230306', 'LP-001', '2023-03-06', 8, 64.0, 1280.00, NOW());



INSERT INTO public."ReporteRendimientoIndividual" (id, codigo, cod_sucursal, codigo_empleado, observaciones, fecha_observacion, ultima_actualizacion)
VALUES
(gen_random_uuid(), 'RRI-LP001-EMP001-20230301', 'LP-001', 'EMP-001', 'Demuestra proactividad en la atención al cliente, logrando aumentar ventas cruzadas.', '2023-03-01', NOW()),
(gen_random_uuid(), 'RRI-LP001-EMP002-20230301', 'LP-001', 'EMP-002', 'Necesita mejorar la velocidad en el procesamiento de pedidos, se observan demoras en horas pico.', '2023-03-01', NOW()),
(gen_random_uuid(), 'RRI-SCZ001-EMP003-20230302', 'SCZ-001', 'EMP-003', 'Excelente manejo de inventario, minimizando errores y pérdidas.', '2023-03-02', NOW()), -- Suponiendo otra sucursal
(gen_random_uuid(), 'RRI-LP001-EMP001-20230305', 'LP-001', 'EMP-001', 'Participa activamente en la capacitación de nuevos compañeros, mostrando liderazgo.', '2023-03-05', NOW()),
(gen_random_uuid(), 'RRI-CBBA001-EMP004-20230303', 'CBBA-001', 'EMP-004', 'Cumple con los objetivos de venta, pero podría optimizar el tiempo de descanso.', '2023-03-03', NOW()), -- Suponiendo otra sucursal
(gen_random_uuid(), 'RRI-LP001-EMP005-20230306', 'LP-001', 'EMP-005', 'Demuestra gran capacidad para resolver problemas complejos con clientes insatisfechos.', '2023-03-06', NOW()),
(gen_random_uuid(), 'RRI-SCZ001-EMP006-20230304', 'SCZ-001', 'EMP-006', 'Se observa una disminución en la eficiencia al final de la jornada laboral. Revisar carga de trabajo.', '2023-03-04', NOW()), -- Suponiendo otra sucursal
(gen_random_uuid(), 'RRI-LP001-EMP002-20230307', 'LP-001', 'EMP-002', 'Ha mostrado mejoras significativas en la gestión del tiempo y la rapidez en caja.', '2023-03-07', NOW()),
(gen_random_uuid(), 'RRI-CBBA001-EMP007-20230305', 'CBBA-001', 'EMP-007', 'Mantiene el área de trabajo impecable y organizada, contribuyendo a un mejor ambiente.', '2023-03-05', NOW()), -- Suponiendo otra sucursal
(gen_random_uuid(), 'RRI-LP001-EMP008-20230308', 'LP-001', 'EMP-008', 'Necesita reforzar conocimientos sobre los nuevos productos lanzados este mes.', '2023-03-08', NOW());



INSERT INTO public."ReporteInventarioDiario" (id, codigo, cod_sucursal, fecha, codigo_producto, stock_final_dia, entrada_del_dia, salida_del_dia, ultima_actualizacion)
VALUES
(gen_random_uuid(), 'RID-LP001-LM001-20230301', 'LP-001', '2023-03-01', 'LM-001', 350, 100, 150, NOW()), -- Leche entera
(gen_random_uuid(), 'RID-LP001-YM002-20230301', 'LP-001', '2023-03-01', 'YM-002', 180, 50, 70, NOW()), -- Yogurt natural
(gen_random_uuid(), 'RID-SCZ001-LM001-20230301', 'SCZ-001', '2023-03-01', 'LM-001', 420, 150, 100, NOW()), -- Leche entera en otra sucursal
(gen_random_uuid(), 'RID-LP001-CM003-20230302', 'LP-001', '2023-03-02', 'CM-003', 220, 80, 60, NOW()), -- Queso fresco
(gen_random_uuid(), 'RID-LP001-LM001-20230302', 'LP-001', '2023-03-02', 'LM-001', 300, 50, 100, NOW()), -- Leche entera, día siguiente
(gen_random_uuid(), 'RID-CBBA001-YM002-20230302', 'CBBA-001', '2023-03-02', 'YM-002', 250, 100, 80, NOW()), -- Yogurt natural en otra sucursal
(gen_random_uuid(), 'RID-LP001-YM002-20230302', 'LP-001', '2023-03-02', 'YM-002', 150, 30, 60, NOW()), -- Yogurt natural, día siguiente
(gen_random_uuid(), 'RID-SCZ001-CM003-20230302', 'SCZ-001', '2023-03-02', 'CM-003', 300, 120, 70, NOW()), -- Queso fresco en otra sucursal
(gen_random_uuid(), 'RID-LP001-LM001-20230303', 'LP-001', '2023-03-03', 'LM-001', 380, 100, 20, NOW()), -- Leche entera, un día de baja salida
(gen_random_uuid(), 'RID-CBBA001-LM001-20230303', 'CBBA-001', '2023-03-03', 'LM-001', 500, 180, 150, NOW()); -- Leche entera en otra sucursal




INSERT INTO public."ReporteIngresoDiario" (id, codigo, cod_sucursal, fecha, total_ingreso_por_ventas, total_otros_ingresos, ultima_actualizacion)
VALUES
(gen_random_uuid(), 'RID-LP001-20230301', 'LP-001', '2023-03-01', 1520.50, 50.00, NOW()),
(gen_random_uuid(), 'RID-LP001-20230302', 'LP-001', '2023-03-02', 1850.75, 75.00, NOW()),
(gen_random_uuid(), 'RID-SCZ001-20230301', 'SCZ-001', '2023-03-01', 2100.00, 100.00, NOW()), -- Suponiendo otra sucursal
(gen_random_uuid(), 'RID-LP001-20230303', 'LP-001', '2023-03-03', 1300.20, 30.00, NOW()),
(gen_random_uuid(), 'RID-CBBA001-20230301', 'CBBA-001', '2023-03-01', 1750.30, 60.00, NOW()), -- Suponiendo otra sucursal
(gen_random_uuid(), 'RID-LP001-20230304', 'LP-001', '2023-03-04', 1680.00, 45.00, NOW()),
(gen_random_uuid(), 'RID-SCZ001-20230302', 'SCZ-001', '2023-03-02', 2350.90, 120.00, NOW()), -- Suponiendo otra sucursal
(gen_random_uuid(), 'RID-LP001-20230305', 'LP-001', '2023-03-05', 1990.40, 80.00, NOW()),
(gen_random_uuid(), 'RID-CBBA001-20230302', 'CBBA-001', '2023-03-02', 1900.80, 70.00, NOW()), -- Suponiendo otra sucursal
(gen_random_uuid(), 'RID-LP001-20230306', 'LP-001', '2023-03-06', 1450.10, 40.00, NOW());



INSERT INTO public."ReporteGastoDiario" (id, codigo, cod_sucursal, fecha, total_gastos_operativos, total_gastos_laborales, total_otros_gastos, ultima_actualizacion)
VALUES
(gen_random_uuid(), 'RGD-LP001-20230301', 'LP-001', '2023-03-01', 350.00, 1280.00, 50.00, NOW()),
(gen_random_uuid(), 'RGD-LP001-20230302', 'LP-001', '2023-03-02', 280.00, 1120.00, 30.00, NOW()),
(gen_random_uuid(), 'RGD-SCZ001-20230301', 'SCZ-001', '2023-03-01', 420.00, 1920.00, 70.00, NOW()), -- Suponiendo otra sucursal
(gen_random_uuid(), 'RGD-LP001-20230303', 'LP-001', '2023-03-03', 310.00, 1440.00, 40.00, NOW()),
(gen_random_uuid(), 'RGD-CBBA001-20230301', 'CBBA-001', '2023-03-01', 390.00, 1600.00, 60.00, NOW()), -- Suponiendo otra sucursal
(gen_random_uuid(), 'RGD-LP001-20230304', 'LP-001', '2023-03-04', 300.00, 1280.00, 45.00, NOW()),
(gen_random_uuid(), 'RGD-SCZ001-20230302', 'SCZ-001', '2023-03-02', 450.00, 1760.00, 80.00, NOW()), -- Suponiendo otra sucursal
(gen_random_uuid(), 'RGD-LP001-20230305', 'LP-001', '2023-03-05', 330.00, 1120.00, 35.00, NOW()),
(gen_random_uuid(), 'RGD-CBBA001-20230302', 'CBBA-001', '2023-03-02', 400.00, 1440.00, 55.00, NOW()), -- Suponiendo otra sucursal
(gen_random_uuid(), 'RGD-LP001-20230306', 'LP-001', '2023-03-06', 290.00, 1280.00, 25.00, NOW());



-- Detalles para el ReporteGastoDiario con codigo 'RGD-LP001-20230301' (5 detalles)
INSERT INTO public."GastoDiarioDetalle" (id, codigo, id_reporte_gasto_diario, codigo_gasto_original, tipo_gasto, monto, detalle, ultima_actualizacion)
VALUES
(gen_random_uuid(), 'GDD-LP001-0301-01', (SELECT id FROM public."ReporteGastoDiario" WHERE codigo = 'RGD-LP001-20230301'), 'GSO-LUZ-001', 'Servicios Básicos', 100.00, 'Consumo eléctrico del día.', NOW()),
(gen_random_uuid(), 'GDD-LP001-0301-02', (SELECT id FROM public."ReporteGastoDiario" WHERE codigo = 'RGD-LP001-20230301'), 'GOM-MAT-002', 'Materiales Limpieza', 50.00, 'Compra de desinfectante y trapeadores.', NOW()),
(gen_random_uuid(), 'GDD-LP001-0301-03', (SELECT id FROM public."ReporteGastoDiario" WHERE codigo = 'RGD-LP001-20230301'), 'GPR-SEG-003', 'Seguridad', 80.00, 'Pago por servicio de monitoreo.', NOW()),
(gen_random_uuid(), 'GDD-LP001-0301-04', (SELECT id FROM public."ReporteGastoDiario" WHERE codigo = 'RGD-LP001-20230301'), 'GOF-SUM-004', 'Suministros Oficina', 30.00, 'Resma de papel y bolígrafos.', NOW()),
(gen_random_uuid(), 'GDD-LP001-0301-05', (SELECT id FROM public."ReporteGastoDiario" WHERE codigo = 'RGD-LP001-20230301'), 'GOT-MANT-005', 'Mantenimiento Menor', 90.00, 'Reparación de una cerradura en almacén.', NOW());

-- Detalles para el ReporteGastoDiario con codigo 'RGD-LP001-20230302' (5 detalles)
INSERT INTO public."GastoDiarioDetalle" (id, codigo, id_reporte_gasto_diario, codigo_gasto_original, tipo_gasto, monto, detalle, ultima_actualizacion)
VALUES
(gen_random_uuid(), 'GDD-LP001-0302-01', (SELECT id FROM public."ReporteGastoDiario" WHERE codigo = 'RGD-LP001-20230302'), 'GSO-AGUA-001', 'Servicios Básicos', 25.00, 'Consumo de agua potable del día.', NOW()),
(gen_random_uuid(), 'GDD-LP001-0302-02', (SELECT id FROM public."ReporteGastoDiario" WHERE codigo = 'RGD-LP001-20230302'), 'GOM-ALQ-002', 'Alquiler', 200.00, 'Pago de parte proporcional de alquiler del día.', NOW()),
(gen_random_uuid(), 'GDD-LP001-0302-03', (SELECT id FROM public."ReporteGastoDiario" WHERE codigo = 'RGD-LP001-20230302'), 'GPR-PUB-003', 'Publicidad', 40.00, 'Gasto en flyers publicitarios.', NOW()),
(gen_random_uuid(), 'GDD-LP001-0302-04', (SELECT id FROM public."ReporteGastoDiario" WHERE codigo = 'RGD-LP001-20230302'), 'GOF-COM-004', 'Comunicación', 15.00, 'Recarga de teléfono corporativo.', NOW()),
(gen_random_uuid(), 'GDD-LP001-0302-05', (SELECT id FROM public."ReporteGastoDiario" WHERE codigo = 'RGD-LP001-20230302'), 'GOT-VAR-005', 'Varios', 50.00, 'Compra de insumos menores para personal.', NOW());

-- Detalles para el ReporteGastoDiario con codigo 'RGD-SCZ001-20230301' (5 detalles)
INSERT INTO public."GastoDiarioDetalle" (id, codigo, id_reporte_gasto_diario, codigo_gasto_original, tipo_gasto, monto, detalle, ultima_actualizacion)
VALUES
(gen_random_uuid(), 'GDD-SCZ001-0301-01', (SELECT id FROM public."ReporteGastoDiario" WHERE codigo = 'RGD-SCZ001-20230301'), 'GSO-LUZ-002', 'Servicios Básicos', 180.00, 'Consumo eléctrico sucursal Santa Cruz.', NOW()),
(gen_random_uuid(), 'GDD-SCZ001-0301-02', (SELECT id FROM public."ReporteGastoDiario" WHERE codigo = 'RGD-SCZ001-20230301'), 'GOM-MANT-003', 'Mantenimiento Preventivo', 120.00, 'Revisión y limpieza de equipos de aire acondicionado.', NOW()),
(gen_random_uuid(), 'GDD-SCZ001-0301-03', (SELECT id FROM public."ReporteGastoDiario" WHERE codigo = 'RGD-SCZ001-20230301'), 'GPR-LIC-004', 'Licencias Software', 70.00, 'Renovación de licencia de software de inventario.', NOW()),
(gen_random_uuid(), 'GDD-SCZ001-0301-04', (SELECT id FROM public."ReporteGastoDiario" WHERE codigo = 'RGD-SCZ001-20230301'), 'GOF-TRAN-005', 'Transporte', 30.00, 'Gastos de envío de documentación interna.', NOW()),
(gen_random_uuid(), 'GDD-SCZ001-0301-05', (SELECT id FROM public."ReporteGastoDiario" WHERE codigo = 'RGD-SCZ001-20230301'), 'GOT-COMIDA-006', 'Representación', 20.00, 'Compra de refrigerios para reunión de personal.', NOW());



-- Detalles para el ReporteIngresoDiario con codigo 'RID-LP001-20230301' (5 detalles)
INSERT INTO public."DetalleIngresoDiario" (id, codigo, id_reporte_ingreso_diario, codigo_ingreso_original, tipo_ingreso, monto, detalle, ultima_actualizacion)
VALUES
(gen_random_uuid(), 'DID-LP001-0301-01', (SELECT id FROM public."ReporteIngresoDiario" WHERE codigo = 'RID-LP001-20230301'), 'INGV-LP001-001', 'Venta Productos Lácteos', 800.00, 'Ingreso por ventas de leche, queso y yogur.', NOW()),
(gen_random_uuid(), 'DID-LP001-0301-02', (SELECT id FROM public."ReporteIngresoDiario" WHERE codigo = 'RID-LP001-20230301'), 'INGV-LP001-002', 'Venta Productos Derivados', 720.50, 'Ingreso por ventas de mantequilla y postres lácteos.', NOW()),
(gen_random_uuid(), 'DID-LP001-0301-03', (SELECT id FROM public."ReporteIngresoDiario" WHERE codigo = 'RID-LP001-20230301'), 'INGO-SERV-001', 'Servicios Adicionales', 30.00, 'Ingreso por servicio de empaque especial.', NOW()),
(gen_random_uuid(), 'DID-LP001-0301-04', (SELECT id FROM public."ReporteIngresoDiario" WHERE codigo = 'RID-LP001-20230301'), 'INGO-ALQ-002', 'Alquiler Espacio', 20.00, 'Ingreso por alquiler de un pequeño espacio publicitario.', NOW()),
(gen_random_uuid(), 'DID-LP001-0301-05', (SELECT id FROM public."ReporteIngresoDiario" WHERE codigo = 'RID-LP001-20230301'), 'INGV-LP001-003', 'Venta Snacks', 0.00, 'Ingreso no registrado en este detalle (simulando que se sumó en los primeros 2).', NOW()); -- Ajustado para sumar al total_ingreso_por_ventas

-- Detalles para el ReporteIngresoDiario con codigo 'RID-LP001-20230302' (5 detalles)
INSERT INTO public."DetalleIngresoDiario" (id, codigo, id_reporte_ingreso_diario, codigo_ingreso_original, tipo_ingreso, monto, detalle, ultima_actualizacion)
VALUES
(gen_random_uuid(), 'DID-LP001-0302-01', (SELECT id FROM public."ReporteIngresoDiario" WHERE codigo = 'RID-LP001-20230302'), 'INGV-LP001-004', 'Venta Productos Lácteos', 1000.00, 'Ingreso por ventas de leche y yogur en promoción.', NOW()),
(gen_random_uuid(), 'DID-LP001-0302-02', (SELECT id FROM public."ReporteIngresoDiario" WHERE codigo = 'RID-LP001-20230302'), 'INGV-LP001-005', 'Venta Productos Panadería', 850.75, 'Ingreso por ventas de panadería y repostería.', NOW()),
(gen_random_uuid(), 'DID-LP001-0302-03', (SELECT id FROM public."ReporteIngresoDiario" WHERE codigo = 'RID-LP001-20230302'), 'INGO-RECARGA-003', 'Recarga Móvil', 15.00, 'Ingreso por recargas de teléfonos celulares.', NOW()),
(gen_random_uuid(), 'DID-LP001-0302-04', (SELECT id FROM public."ReporteIngresoDiario" WHERE codigo = 'RID-LP001-20230302'), 'INGO-CAJA-004', 'Ajuste de Caja', 60.00, 'Ingreso por ajuste positivo de caja del día.', NOW()),
(gen_random_uuid(), 'DID-LP001-0302-05', (SELECT id FROM public."ReporteIngresoDiario" WHERE codigo = 'RID-LP001-20230302'), 'INGV-LP001-006', 'Venta Bebidas', 0.00, 'Ingreso no registrado en este detalle (simulando que se sumó en los primeros 2).', NOW());

-- Detalles para el ReporteIngresoDiario con codigo 'RID-SCZ001-20230301' (5 detalles)
INSERT INTO public."DetalleIngresoDiario" (id, codigo, id_reporte_ingreso_diario, codigo_ingreso_original, tipo_ingreso, monto, detalle, ultima_actualizacion)
VALUES
(gen_random_uuid(), 'DID-SCZ001-0301-01', (SELECT id FROM public."ReporteIngresoDiario" WHERE codigo = 'RID-SCZ001-20230301'), 'INGV-SCZ001-001', 'Venta Productos Lácteos', 1200.00, 'Venta de línea premium de lácteos.', NOW()),
(gen_random_uuid(), 'DID-SCZ001-0301-02', (SELECT id FROM public."ReporteIngresoDiario" WHERE codigo = 'RID-SCZ001-20230301'), 'INGV-SCZ001-002', 'Venta Productos Orgánicos', 900.00, 'Venta de productos orgánicos y saludables.', NOW()),
(gen_random_uuid(), 'DID-SCZ001-0301-03', (SELECT id FROM public."ReporteIngresoDiario" WHERE codigo = 'RID-SCZ001-20230301'), 'INGO-TUTOR-005', 'Ingreso por Curso', 50.00, 'Cobro por taller de elaboración de yogur casero.', NOW()),
(gen_random_uuid(), 'DID-SCZ001-0301-04', (SELECT id FROM public."ReporteIngresoDiario" WHERE codigo = 'RID-SCZ001-20230301'), 'INGO-VARIOS-006', 'Otros Ingresos', 50.00, 'Ingresos diversos por ventas de merchandising.', NOW()),
(gen_random_uuid(), 'DID-SCZ001-0301-05', (SELECT id FROM public."ReporteIngresoDiario" WHERE codigo = 'RID-SCZ001-20230301'), 'INGV-SCZ001-003', 'Venta Postres', 0.00, 'Ingreso no registrado en este detalle (simulando que se sumó en los primeros 2).', NOW());


INSERT INTO "GerenteSucursal" (id, ci, nombre, apellido, telefono, email, cod_sucursal, fecha_inicio_gerencia, fecha_fin_gerencia, estado, ultima_actualizacion)
VALUES
(
    'a1b2c3d4-e5f6-7890-1234-567890abcdef'::uuid, -- Genera un UUID único
    '12345678LP',
    'Ana',
    'García',
    '77712345',
    'ana.garcia@lechelp.com',
    'LP-001',
    '2020-01-15',
    '2022-06-30',
    'Inactivo',
    CURRENT_TIMESTAMP
),
(
    'b2c3d4e5-f6a7-8901-2345-67890abcdef0'::uuid, -- Genera un UUID único
    '87654321LP',
    'Carlos',
    'Ramírez',
    '77798765',
    'carlos.ramirez@lechelp.com',
    'LP-001',
    '2022-07-01',
    NULL, -- Activo actualmente
    'Activo',
    CURRENT_TIMESTAMP
),
(
    'c3d4e5f6-a7b8-9012-3456-7890abcdef01'::uuid, -- Genera un UUID único
    '11223344LP',
    'Sofía',
    'Martínez',
    '77755566',
    'sofia.martinez@lechelp.com',
    'LP-001',
    '2018-03-01',
    '2020-01-14',
    'Inactivo',
    CURRENT_TIMESTAMP
);