.PHONY: run-db
run-db:
	docker-compose up db -d

.PHONY: run-shell
run-shell:
	docker run -i -t entity_framework_app

.PHONY: run
run:
	docker-compose up app