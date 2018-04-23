El ejercicio de DataStructures tiene complejidad exponencial debido a el -contains- dentro del bucle

	for (LogLine logLine : this) {
        String ip = logLine.getIP();
        if (!this.uniqueIps.contains(ip)) {
            this.uniqueIps.add(ip);
        }
    }

 Se puede cambiar a complejidad lineal utilizando hashtables.