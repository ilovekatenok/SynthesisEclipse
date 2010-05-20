SYNTAXDEF snt
FOR <http://Synthesis.ecore> <./Synthesis.genmodel>
START ModuleDef

OPTIONS {
    licenceHeader ="platform:/resource/org.reuseware/licence.txt";
	generateCodeFromGeneratorModel = "true";
	overrideManifest = "true";
	overrideBuildProperties = "true";
	overrideClasspath = "true";
	overrideProjectFile = "true";
	reloadGeneratorModel = "true";
	tokenspace = "1";	    
}

TOKENS {
	DEFINE COMMENT $'#'(~('\n'|'\r'))*$;
}

TOKENSTYLES {
	"in"                  COLOR #7F0055, BOLD;
	"class_specification" COLOR #7F0055, BOLD;
	"instance_type"       COLOR #7F0055, BOLD;
	"type"                COLOR #7F0055, BOLD;
}


RULES {

	ModuleDef ::= "{" name[] ";" 
					"in" ":" "module;"
					("class_specification" ":" containedClasses* ";")+
					("class_specification" ":" containedFunctions* ";")+
					("type" ":" containedTypes*)+								
				"}" ";";
	ClassDef ::= "{" name[] ";"
				  "in" ":" "class;"
				  "instance_type" ":"  instanceType*
				  "}" ";";
	ADTDef ::= "{" name[] ";"
					"in" ":" "type;"
					"}" ";";
					
}

