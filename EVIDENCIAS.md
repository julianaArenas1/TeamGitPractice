# EVIDENCIAS DE LA PRÁCTICA 1 - GIT COLABORATIVO

**Equipo:** Los Indesplegables  
**Repositorio:** `julianaArenas1/TeamGitPractice`  

---

## 1. Tabla General de Integrantes

| Integrante | Rama personal | Commit consola | Commit Visual Studio | Pull Request | Reviewer |
| :--- | :--- | :--- | :--- | :--- | :--- |
| **Juliana Arenas Arias** | `juliana-arenas` | `7035685` | `989d5c6` | PR #1 | Juan David Ramírez López |
| **Juan David Ramírez López** | `juan-ramirez` | `60e9071` | `803c850` | PR #4 | Heyner Mena Mosquera |
| **Heyner Mena Mosquera** | `heyner-mena` | `61cf668` | `4172964` | PR #3 | Camilo Ospina Hernández |
| **Camilo Ospina Hernández** | `camilo-ospina` | `2a7525b` | `a7eccf1` | PR #5 | Oscar Alexis Pineda Henao |
| **Oscar Alexis Pineda Henao** | `oscar-pineda` | `eb5374c` | `5212081` | PR #2 | Juliana Arenas Arias |

---

## 2. Resolución de Conflictos (Fase 6)

* **Enlace o número del Pull Request donde se resolvió el conflicto:** Pull Request #3 (`feat: add version endpoint`)
* **Hash del commit que resolvió el conflicto:** `d9cd623` (`fix: resolve team message conflict`) realizado por Heyner Mena en la rama `heyner-mena` sobre el archivo `TeamMessage.txt`.

---

## 3. Recuperación de Cambios: Restore y Revert (Fase 7)

### A. Evidencia de uso de `git restore` y `git restore --staged` (Integrante 4: Camilo Ospina)
* **Descartar cambios en el Working Directory (`git restore`):**
  1. Modificación no deseada local en el archivo `README.md`.
  2. Verificación de estado con `git status` (archivo modificado en rojo, sin preparar).
  3. Ejecución de `git restore README.md`.
  4. Verificación con `git status` comprobando que el archivo volvió al estado del último commit y el árbol de trabajo quedó limpio.

* **Descartar cambios del Staging Area (`git restore --staged`):**
  1. Modificación en `README.md` y pase a preparación mediante `git add README.md`.
  2. Verificación con `git status` (archivo en verde en el Staging Area).
  3. Ejecución de `git restore --staged README.md`.
  4. Verificación con `git status` confirmando que el archivo salió del Staging Area y pasó a modificaciones no preparadas (en rojo).
  5. Limpieza final del archivo con `git restore README.md`.

### B. Evidencia de uso de `git revert` (Integrante 5: Oscar Alexis Pineda)
* **Rama de demostración:** `oscar-pineda-revert`
* **Hash del commit temporal:** `95c742c` (`test: add temporary note`)
* **Hash del commit generado por revert:** `2a8c2a7` (`Revert "test: add temporary note"`)

---

## 4. Capturas de Pantalla Requeridas

> *Adjuntar o reemplazar con los archivos de imagen correspondientes:*

1. **Captura de Git Changes (Visual Studio Community 2026):**
   * Muestra la interfaz gráfica de Git en Visual Studio durante el commit con GUI.
   *(Espacio reservado para captura de Git Changes)*

2. **Captura de Git Bash / Terminal integrada:**
   * Muestra la ejecución de comandos de consola (`git status`, `git commit`, `git restore`).
   *(Espacio reservado para captura de consola)*

---

## 5. Comprobación de Colaborador Docente
* El usuario de GitHub del docente **`orlapez`** fue agregado como colaborador con permisos de lectura/escritura en el repositorio `julianaArenas1/TeamGitPractice`.
*(Espacio reservado para captura de confirmación en Settings > Collaborators)*
